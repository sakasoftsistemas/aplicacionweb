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
    public class tipoUsuario_da
    {
        static SqlConnection con = conexion.getConexion();
        public static List<tipoUsuario> obtenerTipoUsuario()
        {
            List<tipoUsuario> lista = new List<tipoUsuario>();
            try
            {
                SqlCommand cmd = new SqlCommand("usp_tipoUsuario", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                tipoUsuario u;
                while (dr.Read())
                {
                    u = new tipoUsuario();
                    int idTipoUsuario = (int)dr["idTipoUsuario"];
                    string descripcion = (string)dr["descripcion"];
                    u.idTipoUsuario = idTipoUsuario;
                    u.descripcion = descripcion;
                    lista.Add(u);
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
