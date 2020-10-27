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
    public class D_Area
    {
        readonly SqlConnection conectar = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);

        public DataTable MostrarRegistro()
        {
            DataTable DtResultado = new DataTable();
            SqlCommand SqlCmd = new SqlCommand("SPMOSTRAR_AREA", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
            SqlDat.Fill(DtResultado);

            return DtResultado;
        }

        public void InsertarRegistro(E_Area area)
        {
            SqlCommand SqlCmd = new SqlCommand("SPINSERTAR_AREA", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            conectar.Open();

            SqlCmd.Parameters.AddWithValue("@TIPO", area.Tipo);
            SqlCmd.Parameters.AddWithValue("@NOMBRE", area.Nombre);

            SqlCmd.ExecuteNonQuery();

            conectar.Close();
        }

        public void EditarRegistro(E_Area area)
        {
            SqlCommand SqlCmd = new SqlCommand("SPEDITAR_AREA", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            conectar.Open();

            SqlCmd.Parameters.AddWithValue("@TIPO", area.Tipo);
            SqlCmd.Parameters.AddWithValue("@NOMBRE", area.Nombre);

            SqlCmd.ExecuteNonQuery();

            conectar.Close();
        }

        public void EliminarRegistro(E_Area area)
        {
            SqlCommand SqlCmd = new SqlCommand("SPELIMINAR_AREA", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            conectar.Open();

            SqlCmd.Parameters.AddWithValue("@TIPO", area.Tipo);

            SqlCmd.ExecuteNonQuery();

            conectar.Close();
        }
    }
}
