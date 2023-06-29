using PruebaOperador.Api.Model.DTO.Persona;
using PruebaOperador.Api.Model.DTO.ResponseServices;
using PruebaOperador.Api.Model.Response;
using PruebaOperador.Api.Services.Command;
using PruebaOperador.Api.Services.Invoker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PruebaOperador.Api.BusinessServices.Invoker
{
    public class PersonaIncoker : IPersonaInvoker
    {
        private readonly IPersonaCommand personaCommand;

        public PersonaIncoker(IPersonaCommand personaCommand)
        {
            this.personaCommand = personaCommand;
        }
        public async Task<ResponseServices<bool>> GuardarPersona(PersonaDTO personaDTO)
        {
            try
            {
                Regex regex = new Regex("^[0-9]+$");
                Regex regAlfa = new Regex("^[a-zA-Z0-9]*$");

                if (string.IsNullOrEmpty(personaDTO.Identificacion) || string.IsNullOrEmpty(personaDTO.Nombres) || string.IsNullOrEmpty(personaDTO.Apellidos) || personaDTO.FechaNacimiento == null) 
                {
                    return ResponseStatus.ResponseWithoutData<bool>("La idenificación, los nombres y la fecha de nacimiento son campos obigatorios");
                }
                if (regex.IsMatch(personaDTO.Nombres) || regex.IsMatch(personaDTO.Apellidos))
                {
                    return ResponseStatus.ResponseWithoutData<bool>("Los nombres no pueden contener números");
                }
                if(!regAlfa.IsMatch(personaDTO.Identificacion))
                {
                    return ResponseStatus.ResponseWithoutData<bool>("La identificación no puede tener carácteres especiales");
                }
                if (string.IsNullOrEmpty(personaDTO.DireccionPrincipal) && string.IsNullOrEmpty(personaDTO.CorreoPrincipal))
                {
                    return ResponseStatus.ResponseWithoutData<bool>("Debe registrar un correo o una dirección");
                }
                await this.personaCommand.GuardarPersona(personaDTO);
                return ResponseStatus.ResponseSucessful<bool>(true);
            }
            catch (Exception e)
            {
                return ResponseStatus.ResponseWithoutData<bool>(e.InnerException.Message);
            }
            
        }
    }
}
