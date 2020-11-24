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
    public class login_da
    {
        static SqlConnection con = conexion.getConexion();
        public static List<usuario> iniciarSesion(string usu, string contrasenia)
        {
            List<usuario> lista = new List<usuario>();
            try
            {
                SqlCommand cmd = new SqlCommand("usp_login", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@usu", usu);
                cmd.Parameters.AddWithValue("@contrasenia", contrasenia);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                usuario u;
                while (dr.Read())
                {
                    u = new usuario();
                    int idUsuario = (int)dr["idUsuario"];
                    string nombres = (string)dr["nombres"];
                    string apePaterno = (string)dr["apePaterno"];
                    string apeMaterno = (string)dr["apeMaterno"];
                    u.idUsuario = idUsuario;
                    u.nombres = nombres;
                    u.apePaterno = apePaterno;
                    u.apeMaterno = apeMaterno;
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
