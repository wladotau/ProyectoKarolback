using System;
using System.Collections.Generic;

namespace ProyectoKarol.Models
{
    public partial class Usuario
    {
        public int IdUsuario { get; set; }
        public string RolUsu { get; set; } = null!;
        public string NomUsuario { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string EstadoUsu { get; set; } = null!;
        public int IdPersona { get; set; }

        public virtual Persona IdPersonaNavigation { get; set; } = null!;
    }
}
