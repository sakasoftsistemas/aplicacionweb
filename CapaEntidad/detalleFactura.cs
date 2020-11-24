using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class detalleFactura
    {
        public string serieFactura { get; set; }
        public string numFactura { get; set; }
        public int idProducto { get; set; }
        public int cantidad { get; set; }
        public string precio { get; set; }
    }
}
