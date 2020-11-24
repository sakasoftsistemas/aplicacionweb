using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
namespace CapaNegocio
{
    public class tipoProducto_ne
    {
        public static List<tipoProducto> obtenerTipoProductos()
        {
            try
            {
                return tipoProducto_da.obtenerTipoProductos();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
