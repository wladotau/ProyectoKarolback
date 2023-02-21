using System;
using System.Collections.Generic;

namespace ProyectoKarol.Models
{
    public partial class InventarioPlatillo
    {
        public int IdInventarioPlatillo { get; set; }
        public int Cantidad { get; set; }
        public int IdPlatillo { get; set; }
        public int IdProducto { get; set; }

        public virtual Platillo IdPlatilloNavigation { get; set; } = null!;
        public virtual Producto IdProductoNavigation { get; set; } = null!;
    }
}
