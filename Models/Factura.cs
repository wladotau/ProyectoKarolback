using System;
using System.Collections.Generic;

namespace ProyectoKarol.Models
{
    public partial class Factura
    {
        public Factura()
        {
            PlatilloXfacturas = new HashSet<PlatilloXfactura>();
        }

        public int IdFactura { get; set; }
        public DateTime FechaFactura { get; set; }
        public int Cantidad { get; set; }
        public int Valor { get; set; }
        public int Total { get; set; }
        public string FormaPago { get; set; } = null!;
        public string EstadoFactura { get; set; } = null!;
        public int IdPedido { get; set; }

        public virtual Pedido IdPedidoNavigation { get; set; } = null!;
        public virtual ICollection<PlatilloXfactura> PlatilloXfacturas { get; set; }
    }
}
