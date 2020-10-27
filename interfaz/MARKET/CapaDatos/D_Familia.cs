using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using CapaEntidades;

namespace CapaDatos
{
    public class D_Familia
    {
        readonly SqlConnection conectar = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);

        public DataTable MostrarRegistro()
        {
            DataTable DtResultado = new DataTable();
            SqlCommand SqlCmd = new SqlCommand("SPMOSTRAR_FAMILIA", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
            SqlDat.Fill(DtResultado);

            return DtResultado;
        }

        public void InsertarRegistro(E_Familia familia)
        {
            SqlCommand SqlCmd = new SqlCommand("SPINSERTAR_FAMILIA", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            conectar.Open();

            SqlCmd.Parameters.AddWithValue("@TIPO", familia.Tipo);
            SqlCmd.Parameters.AddWithValue("@NOMBRE", familia.Nombre);

            SqlCmd.ExecuteNonQuery();

            conectar.Close();
        }

        public void EditarRegistro(E_Familia familia)
        {
            SqlCommand SqlCmd = new SqlCommand("SPEDITAR_FAMILIA", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            conectar.Open();

            SqlCmd.Parameters.AddWithValue("@TIPO", familia.Tipo);
            SqlCmd.Parameters.AddWithValue("@NOMBRE", familia.Nombre);

            SqlCmd.ExecuteNonQuery();

            conectar.Close();
        }

        public void EliminarRegistro(E_Familia familia)
        {
            SqlCommand SqlCmd = new SqlCommand("SPELIMINAR_FAMILIA", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            conectar.Open();

            SqlCmd.Parameters.AddWithValue("@TIPO", familia.Tipo);

            SqlCmd.ExecuteNonQuery();

            conectar.Close();
        }
    }
}
