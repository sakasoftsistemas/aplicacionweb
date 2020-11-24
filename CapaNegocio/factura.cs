using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class factura
    {
        public string serieFactura { get; set; }
        public string numFactura { get; set; }
        public string fechaEmision { get; set; }
        public string fechaVencimiento { get; set; }
        public string idUsuario { get; set; }
        public string subTotal { get; set; }
        public string anticipo { get; set; }
        public string descuento { get; set; }
        public string valorVenta { get; set; }
        public string isc { get; set; }
        public string igv { get; set; }
        public string otroCargo { get; set; }
        public string otroTributo { get; set; }
        public string importeTotal { get; set; }
        public string idTipoMoneda { get; set; }
    }
}
