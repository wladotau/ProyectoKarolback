using System;
using System.Collections.Generic;

namespace ProyectoKarol.Models
{
    public partial class Pedido
    {
        public Pedido()
        {
            Facturas = new HashSet<Factura>();
        }

        public int IdPedido { get; set; }
        public string TipoPedido { get; set; } = null!;
        public DateTime FechaPedido { get; set; }
        public DateTime FechaDespacho { get; set; }
        public string TipoEntrega { get; set; } = null!;
        public int ValorEntrega { get; set; }
        public int IdPersona { get; set; }

        public virtual Persona IdPersonaNavigation { get; set; } = null!;
        public virtual ICollection<Factura> Facturas { get; set; }
    }
}
