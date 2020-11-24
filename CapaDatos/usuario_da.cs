using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace CapaDatos
{
    public class usuario_da
    {
        static SqlConnection con = conexion.getConexion();
        public static Boolean registrarusuario(string dni, string nombres, string apePaterno, string apeMaterno, string direccion, string telefono, string correo, string usu, string contrasenia, int idTipoUsuario)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("usp_registrarUsuario", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@idTipoUsuario", idTipoUsuario);
                cmd.Parameters.AddWithValue("@dni", dni);
                cmd.Parameters.AddWithValue("@nombres", nombres);
                cmd.Parameters.AddWithValue("@apePaterno", apePaterno);
                cmd.Parameters.AddWithValue("@apeMaterno", apeMaterno);
                cmd.Parameters.AddWithValue("@direccion", direccion);
                cmd.Parameters.AddWithValue("@telefono", telefono);
                cmd.Parameters.AddWithValue("@correo", correo);
                cmd.Parameters.AddWithValue("@usu", usu);
                cmd.Parameters.AddWithValue("@contrasenia", contrasenia);
                con.Open();
                int r = cmd.ExecuteNonQuery();
                if (r != 0)
                    return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return false;
        }
        public static Boolean actualizarClave(string dni, string nuevaClave)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("usp_actualizarClave", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@dni", dni);
                cmd.Parameters.AddWithValue("@clave", nuevaClave);
                con.Open();
                int r = cmd.ExecuteNonQuery();
                if (r != 0)
                    return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return false;
        }
        public static int validarCorreo(string dni, string correo)
        {
            int c = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("usp_validarCorreo", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@dni", dni);
                cmd.Parameters.AddWithValue("@correo", correo);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    c = (int)dr["cantidad"];
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
            return c;
        }
    }
}
