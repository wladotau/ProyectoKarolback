using System;
using System.Collections.Generic;

namespace ProyectoKarol.Models
{
    public partial class PlatilloXfactura
    {
        public int IdPlatilloFactura { get; set; }
        public int IdPlatillo { get; set; }
        public int IdFactura { get; set; }

        public virtual Factura IdFacturaNavigation { get; set; } = null!;
        public virtual Platillo IdPlatilloNavigation { get; set; } = null!;
    }
}
