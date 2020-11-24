using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
namespace CapaDatos
{
    public class presentacion_da
    {
        static SqlConnection con = conexion.getConexion();
        public static List<presentacion> obtenerPresentacion(int idTipoProducto)
        {
            List<presentacion> lista = new List<presentacion>();
            try
            {
                SqlCommand cmd = new SqlCommand("usp_presentacion_sel", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@idTipoProducto", idTipoProducto);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                presentacion p;
                while (dr.Read())
                {
                    p = new presentacion();
                    int idPresentacion = (int)dr["idPresentacion"];
                    string descripcion = (string)dr["descripcion"];
                    string imagen = (string)dr["imagen"];
                    p.idPresentacion = idPresentacion;
                    p.descripcion = descripcion;
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
