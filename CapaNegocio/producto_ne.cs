using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;
namespace CapaNegocio
{
    public class producto_ne
    {
        public static List<producto> obtenerProductos(int idPresentacion)
        {
            try
            {
                return producto_da.obtenerProductos(idPresentacion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
