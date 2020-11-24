using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class producto_da
    {
        static SqlConnection con = conexion.getConexion();
        public static List<producto> obtenerProductos(int idPresentacion)
        {
            List<producto> lista = new List<producto>();
            try
            {
                SqlCommand cmd = new SqlCommand("usp_productos_sel", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@idPresentacion", idPresentacion);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                producto p;
                while (dr.Read())
                {
                    p = new producto();
                    int idProducto = Convert.ToInt32(dr["idProducto"]);
                    string descripcion = dr["descripcion"].ToString();
                    string precio = Convert.ToString(Convert.ToDecimal(dr["precio"]));
                    int stockActual = Convert.ToInt32(dr["stockActual"]);
                    string imagen = dr["imagen"].ToString();
                    p.idProducto = idProducto;
                    p.descripcion = descripcion;
                    p.precio = precio;
                    p.stockActual = stockActual;
                    p.imagen = imagen;
                    lista.Add(p);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return lista;
        }
    }
}
