using PruebaOperador.Api.Model.DTO.Persona;
using PruebaOperador.Api.Repository.Entity;
using PruebaOperador.Api.Services.Command;
using PruebaOperador.Api.Services.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaOperador.Api.BusinessServices.Command
{
    public class PersonaCommand : IPersonaCommand
    {
        private readonly IRepositoryGeneric<Persona> repositoryGeneric;

        public PersonaCommand(IRepositoryGeneric<Persona> repositoryGeneric)
        {
            this.repositoryGeneric = repositoryGeneric;
        }

        public async Task GuardarPersona(PersonaDTO personaDTO)
        {
            Persona persona = new Persona
            {
                Identificacion = personaDTO.Identificacion,
                Nombres = personaDTO.Nombres,
                Apellidos = personaDTO.Apellidos,
                FechaNacimiento = personaDTO.FechaNacimiento,
                TelefonoCelular = personaDTO.TelefonoCelular,
                TelefonoFijo = personaDTO.TelefonoFijo,
                DireccionPrincipal  = personaDTO.DireccionPrincipal,
                DireccionOpcional = personaDTO.DireccionOpcional,
                CorreoPrincipal = personaDTO.CorreoPrincipal,
                CorreoSecundario = personaDTO.CorreoSecundario

            };
            await this.repositoryGeneric.AddAsync(persona);
        }
    }
}
