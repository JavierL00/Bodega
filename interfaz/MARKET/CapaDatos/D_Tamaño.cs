using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using CapaEntidades;

namespace CapaDatos
{
    public class D_Tamaño
    {
        readonly SqlConnection conectar = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);

        public DataTable MostrarRegistro()
        {
            DataTable DtResultado = new DataTable();
            SqlCommand SqlCmd = new SqlCommand("SPMOSTRAR_TAMAÑO", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
            SqlDat.Fill(DtResultado);

            return DtResultado;
        }

        public void InsertarRegistro(E_Tamaño tam)
        {
            SqlCommand SqlCmd = new SqlCommand("SPINSERTAR_TAMAÑO", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            conectar.Open();

            SqlCmd.Parameters.AddWithValue("@CODIGO", tam.Codigo);
            SqlCmd.Parameters.AddWithValue("@MEDIDA", tam.Medida);

            SqlCmd.ExecuteNonQuery();

            conectar.Close();
        }

        public void EditarRegistro(E_Tamaño tam)
        {
            SqlCommand SqlCmd = new SqlCommand("SPEDITAR_TAMAÑO", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            conectar.Open();

            SqlCmd.Parameters.AddWithValue("@CODIGO", tam.Codigo);
            SqlCmd.Parameters.AddWithValue("@MEDIDA", tam.Medida);

            SqlCmd.ExecuteNonQuery();

            conectar.Close();
        }

        public void EliminarRegistro(E_Tamaño tam)
        {
            SqlCommand SqlCmd = new SqlCommand("SPELIMINAR_TAMAÑO", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            conectar.Open();

            SqlCmd.Parameters.AddWithValue("@CODIGO", tam.Codigo);

            SqlCmd.ExecuteNonQuery();

            conectar.Close();
        }
    }
}
