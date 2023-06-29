using PruebaOperador.Api.Model.DTO.Persona;
using PruebaOperador.Api.Model.DTO.ResponseServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaOperador.Api.Services.Invoker
{
    public interface IPersonaInvoker
    {
        Task<ResponseServices<bool>> GuardarPersona(PersonaDTO personaDTO);
    }
}
