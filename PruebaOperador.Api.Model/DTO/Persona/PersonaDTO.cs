using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaOperador.Api.Model.DTO.Persona
{
    public class PersonaDTO
    {
        public int Id { get; set; }
        public string Identificacion { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string? TelefonoFijo { get; set; }
        public string? TelefonoCelular { get; set; }
        public string? DireccionPrincipal { get; set; }
        public string? DireccionOpcional { get; set; }
        public string? CorreoPrincipal { get; set; }
        public string? CorreoSecundario { get; set; }
    }
}
