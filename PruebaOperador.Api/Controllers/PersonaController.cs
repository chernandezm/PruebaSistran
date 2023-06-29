using Microsoft.AspNetCore.Mvc;
using PruebaOperador.Api.Model.DTO.Persona;
using PruebaOperador.Api.Services.Services;

namespace PruebaOperador.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonaController : ControllerBase
    {
        private readonly IPersonaService personaService;

        public PersonaController(IPersonaService personaService)
        {
            this.personaService = personaService;
        }
        [HttpPost]
        [Route("CrearPersona")]
        public async Task<IActionResult> CrearPersona(PersonaDTO personaDTO)
        {
            return Ok(await this.personaService.GuardarPersona(personaDTO)); 
        }
    }
}
