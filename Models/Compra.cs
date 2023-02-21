using System;
using System.Collections.Generic;

namespace ProyectoKarol.Models
{
    public partial class Compra
    {
        public int IdCompras { get; set; }
        public DateTime FechaCompra { get; set; }
        public DateTime FechaDespacho { get; set; }
        public string TipoCompra { get; set; } = null!;
        public int IdProveedor { get; set; }

        public virtual Proveedor IdProveedorNavigation { get; set; } = null!;
    }
}
