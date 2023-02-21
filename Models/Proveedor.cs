using System;
using System.Collections.Generic;

namespace ProyectoKarol.Models
{
    public partial class Proveedor
    {
        public Proveedor()
        {
            Compras = new HashSet<Compra>();
            Egresos = new HashSet<Egreso>();
        }

        public int IdProveedor { get; set; }
        public string NomProveedor { get; set; } = null!;
        public string Nit { get; set; } = null!;
        public string CorreoProveedor { get; set; } = null!;
        public string TelProveedor { get; set; } = null!;
        public string DirProveedor { get; set; } = null!;
        public int IdProducto { get; set; }

        public virtual Producto IdProductoNavigation { get; set; } = null!;
        public virtual ICollection<Compra> Compras { get; set; }
        public virtual ICollection<Egreso> Egresos { get; set; }
    }
}
