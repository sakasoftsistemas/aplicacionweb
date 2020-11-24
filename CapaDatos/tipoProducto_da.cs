using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
namespace CapaDatos
{
    public class tipoProducto_da
    {
        static SqlConnection con = conexion.getConexion();
        public static List<tipoProducto> obtenerTipoProductos()
        {
            List<tipoProducto> lista = new List<tipoProducto>();
            try
            {
                SqlCommand cmd = new SqlCommand("usp_tipoProducto_sel", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                tipoProducto p;
                while (dr.Read())
                {
                    p = new tipoProducto();
                    int idTipoProducto = Convert.ToInt32(dr["idTipoProducto"]);
                    string descripcion = dr["descripcion"].ToString();
                    p.idTipoProducto = idTipoProducto;
                    p.descripcion = descripcion;
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
