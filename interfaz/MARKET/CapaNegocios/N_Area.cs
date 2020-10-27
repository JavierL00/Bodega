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
    public class N_Area
    {
        readonly D_Area ObjArea = new D_Area();

        public static DataTable MostrarRegistro()
        {
            return new D_Area().MostrarRegistro();
        }

        public void InsertarRegistro(E_Area area)
        {
            ObjArea.InsertarRegistro(area);
        }

        public void EditarRegistro(E_Area area)
        {
            ObjArea.EditarRegistro(area);
        }

        public void EliminarRegistro(E_Area area)
        {
            ObjArea.EliminarRegistro(area);
        }
    }
}
