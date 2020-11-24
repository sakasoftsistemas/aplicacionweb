using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class producto
    {
        public int idProducto { get; set; }
        public string descripcion { get; set; }
        public string precio { get; set; }
        public int stockActual { get; set; }
        public string imagen { get; set; }
    }
}
