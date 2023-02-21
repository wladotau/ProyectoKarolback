using System;
using System.Collections.Generic;

namespace ProyectoKarol.Models
{
    public partial class Producto
    {
        public Producto()
        {
            InventarioPlatillos = new HashSet<InventarioPlatillo>();
            Inventarios = new HashSet<Inventario>();
            Proveedors = new HashSet<Proveedor>();
        }

        public int IdProducto { get; set; }
        public string NomProducto { get; set; } = null!;
        public string Categoria { get; set; } = null!;
        public DateTime? FechaFabricacion { get; set; }
        public DateTime? FechaVencimiento { get; set; }

        public virtual ICollection<InventarioPlatillo> InventarioPlatillos { get; set; }
        public virtual ICollection<Inventario> Inventarios { get; set; }
        public virtual ICollection<Proveedor> Proveedors { get; set; }
    }
}
