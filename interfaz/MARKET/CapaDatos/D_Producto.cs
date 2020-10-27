using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class D_Producto
    {
        readonly SqlConnection conectar = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);

        public DataTable MostrarRegistro()
        {
            DataTable DtResultado = new DataTable();
            SqlCommand SqlCmd = new SqlCommand("SPMOSTRAR_PRODUCTO_DETALLADO", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
            SqlDat.Fill(DtResultado);

            return DtResultado;
        }

        public void InsertarRegistro(E_Producto producto)
        {
            SqlCommand SqlCmd = new SqlCommand("SPINSERTAR_PRODUCTO", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            conectar.Open();

            SqlCmd.Parameters.AddWithValue("@CODIGO", producto.Codigo);
            SqlCmd.Parameters.AddWithValue("@AREA", producto.Area);
            SqlCmd.Parameters.AddWithValue("@FAMILIA", producto.Familia);
            SqlCmd.Parameters.AddWithValue("@MARCA", producto.Marca);
            SqlCmd.Parameters.AddWithValue("@DESCRIPCION", producto.Descripcion);
            SqlCmd.Parameters.AddWithValue("@PRESENTACION", producto.Presentacion);
            SqlCmd.Parameters.AddWithValue("@TAMAÑO", producto.Tamaño);
            SqlCmd.Parameters.AddWithValue("@CANTIDAD", producto.Cantidad);
            SqlCmd.Parameters.AddWithValue("@P_COMPRA", producto.P_Compra);
            SqlCmd.Parameters.AddWithValue("@P_VENTA", producto.P_Venta);

            SqlCmd.ExecuteNonQuery();

            conectar.Close();
        }
        public void EditarRegistro(E_Producto producto)
        {
            SqlCommand SqlCmd = new SqlCommand("SPEDITAR_PRODUCTO", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            conectar.Open();

            SqlCmd.Parameters.AddWithValue("@CODIGO", producto.Codigo);
            SqlCmd.Parameters.AddWithValue("@AREA", producto.Area);
            SqlCmd.Parameters.AddWithValue("@FAMILIA", producto.Familia);
            SqlCmd.Parameters.AddWithValue("@MARCA", producto.Marca);
            SqlCmd.Parameters.AddWithValue("@DESCRIPCION", producto.Descripcion);
            SqlCmd.Parameters.AddWithValue("@PRESENTACION", producto.Presentacion);
            SqlCmd.Parameters.AddWithValue("@TAMAÑO", producto.Tamaño);
            SqlCmd.Parameters.AddWithValue("@CANTIDAD", producto.Cantidad);
            SqlCmd.Parameters.AddWithValue("@P_COMPRA", producto.P_Compra);
            SqlCmd.Parameters.AddWithValue("@P_VENTA", producto.P_Venta);

            SqlCmd.ExecuteNonQuery();

            conectar.Close();
        }

        public void EliminarRegistro(E_Producto producto)
        {
            SqlCommand SqlCmd = new SqlCommand("SPELIMINAR_PRODUCTO", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            conectar.Open();

            SqlCmd.Parameters.AddWithValue("@CODIGO", producto.Codigo);

            SqlCmd.ExecuteNonQuery();

            conectar.Close();
        }

        public DataTable BuscarProducto(string texto)
        {
            DataTable DtResultado = new DataTable();
            SqlCommand SqlCmd = new SqlCommand("SPBUSCAR_PRODUCTO", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            SqlCmd.Parameters.AddWithValue("@MARCA", texto);

            SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
            SqlDat.Fill(DtResultado);

            return DtResultado;
        }
    }
}
