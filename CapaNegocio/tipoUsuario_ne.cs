using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;
namespace CapaNegocio
{
    public class tipoUsuario_ne
    {
        public static List<tipoUsuario> obtenerTipoUsuario()
        {
            try
            {
                return tipoUsuario_da.obtenerTipoUsuario();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
