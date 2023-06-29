using PruebaOperador.Api.Model.DTO.Persona;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaOperador.Api.Services.Command
{
    public interface IPersonaCommand
    {
        Task GuardarPersona(PersonaDTO personaDTO);
    }
}
