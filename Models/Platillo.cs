using System;
using System.Collections.Generic;

namespace ProyectoKarol.Models
{
    public partial class Platillo
    {
        public Platillo()
        {
            InventarioPlatillos = new HashSet<InventarioPlatillo>();
            PlatilloXfacturas = new HashSet<PlatilloXfactura>();
        }

        public int IdPlatillo { get; set; }
        public string NomPlatillo { get; set; } = null!;
        public string TipoPlatillo { get; set; } = null!;
        public string DescripPlat { get; set; } = null!;

        public virtual ICollection<InventarioPlatillo> InventarioPlatillos { get; set; }
        public virtual ICollection<PlatilloXfactura> PlatilloXfacturas { get; set; }
    }
}
