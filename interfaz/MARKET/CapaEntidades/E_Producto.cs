using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_Producto
    {
        public string Codigo { get; set; }
        public int Area { get; set; }
        public int Familia { get; set; }
        public string Marca { get; set; }
        public string Descripcion { get; set; }
        public string Presentacion { get; set; }
        public int Tamaño { get; set; }
        public int Cantidad { get; set; }
        public decimal P_Compra { get; set; }
        public decimal P_Venta { get; set; }
    }
}
