using PruebaOperador.Api.Model.DTO.Persona;
using PruebaOperador.Api.Model.DTO.ResponseServices;
using PruebaOperador.Api.Services.Invoker;
using PruebaOperador.Api.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaOperador.Api.BusinessServices.Services
{
    public class PersonaService : IPersonaService
    {
        private readonly IPersonaInvoker personaInvoker;

        public PersonaService(IPersonaInvoker personaInvoker)
        {
            this.personaInvoker = personaInvoker;
        }

        public async Task<ResponseServices<bool>> GuardarPersona(PersonaDTO personaDTO)
        {
            return await this.personaInvoker.GuardarPersona(personaDTO);
        }
    }
}
