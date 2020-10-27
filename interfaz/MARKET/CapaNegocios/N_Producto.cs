using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocios
{
    public class N_Producto
    {
        readonly D_Producto ObjProducto = new D_Producto();

        public static DataTable MostrarRegistro()
        {
            return new D_Producto().MostrarRegistro();
        }

        public void InsertarRegistro(E_Producto producto)
        {
            ObjProducto.InsertarRegistro(producto);
        }

        public void EditarRegistro(E_Producto producto)
        {
            ObjProducto.EditarRegistro(producto);
        }

        public void EliminarRegistro(E_Producto producto)
        {
            ObjProducto.EliminarRegistro(producto);
        }

        public static DataTable BuscarProducto(string texto)
        {
            return new D_Producto().BuscarProducto(texto);
        }
    }
}
