using System;
using System.Collections.Generic;

namespace ProyectoKarol.Models
{
    public partial class Inventario
    {
        public int IdInventario { get; set; }
        public DateTime FechaIngreso { get; set; }
        public int Existencias { get; set; }
        public int IdProducto { get; set; }

        public virtual Producto IdProductoNavigation { get; set; } = null!;
    }
}
