using System;
using System.Collections.Generic;

namespace ProyectoKarol.Models
{
    public partial class Egreso
    {
        public int IdEgreso { get; set; }
        public string TipoEgreso { get; set; } = null!;
        public string DescripEgreso { get; set; } = null!;
        public DateTime FechaPago { get; set; }
        public int IdProveedor { get; set; }

        public virtual Proveedor IdProveedorNavigation { get; set; } = null!;
    }
}
