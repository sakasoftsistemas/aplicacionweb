using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;
namespace CapaNegocio
{
    public class presentacion_ne
    {
        public static List<presentacion> obtenerPresentacion(int idTipoProducto)
        {
            try
            {
                return presentacion_da.obtenerPresentacion(idTipoProducto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
