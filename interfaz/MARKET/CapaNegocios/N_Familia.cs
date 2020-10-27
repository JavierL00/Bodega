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
    public class N_Familia
    {
        readonly D_Familia ObjFamilia = new D_Familia();

        public static DataTable MostrarRegistro()
        {
            return new D_Familia().MostrarRegistro();
        }

        public void InsertarRegistro(E_Familia familia)
        {
            ObjFamilia.InsertarRegistro(familia);
        }

        public void EditarRegistro(E_Familia familia)
        {
            ObjFamilia.EditarRegistro(familia);
        }

        public void EliminarRegistro(E_Familia familia)
        {
            ObjFamilia.EliminarRegistro(familia);
        }
    }
}
