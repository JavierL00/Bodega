using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocios
{
    public class N_Tamaño
    {
        readonly D_Tamaño ObjTamaño = new D_Tamaño();

        public static DataTable MostrarRegistro()
        {
            return new D_Tamaño().MostrarRegistro();
        }

        public void InsertarRegistro(E_Tamaño tam)
        {
            ObjTamaño.InsertarRegistro(tam);
        }

        public void EditarRegistro(E_Tamaño tam)
        {
            ObjTamaño.EditarRegistro(tam);
        }

        public void EliminarRegistro(E_Tamaño tam)
        {
            ObjTamaño.EliminarRegistro(tam);
        }
    }
}
