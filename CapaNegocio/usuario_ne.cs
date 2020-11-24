using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
namespace CapaNegocio
{
    public class usuario_ne
    {
        public static Boolean registrarusuario(string dni, string nombres, string apePaterno, string apeMaterno, string direccion, string telefono, string correo, string usu, string contrasenia, int idTipoUsuario)
        {
            try
            {
                return usuario_da.registrarusuario(dni, nombres, apePaterno, apeMaterno, direccion, telefono, correo, usu, contrasenia, idTipoUsuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static Boolean actualizarClave(string dni, string nuevaClave)
        {
            try
            {
                return usuario_da.actualizarClave(dni, nuevaClave);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static int validarCorreo(string dni, string correo)
        {
            try
            {
                return usuario_da.validarCorreo(dni, correo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
