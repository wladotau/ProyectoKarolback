using System;
using System.Collections.Generic;

namespace ProyectoKarol.Models
{
    public partial class Persona
    {
        public Persona()
        {
            Pedidos = new HashSet<Pedido>();
            Usuarios = new HashSet<Usuario>();
        }

        public int IdPersona { get; set; }
        public long NumDoc { get; set; }
        public string NomPersona { get; set; } = null!;
        public string ApePersona { get; set; } = null!;
        public long TelPersona { get; set; }
        public string CorreoPersona { get; set; } = null!;
        public string Direccion { get; set; } = null!;

        public virtual ICollection<Pedido> Pedidos { get; set; }
        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
