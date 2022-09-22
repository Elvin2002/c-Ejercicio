using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Empresa_tapiceroa
{
     class clsTapiceria
    {
        public string Cliente { set; get; }
        public string Mueble { set; get; }
        public double Precio { get; set; }
        public double Descuento { get; set; }
        public double PrecioVenta { get; set; }

        public double Descuentos()
        {
      
            if (this.Precio >= 500)
            {
                this.Descuento = 0.10;
                return this.Descuento;
            }
            else
            {
                this.Descuento = 0.02;
                return this.Descuento;
            }


            

        }
        public double precio_final()
        {
            PrecioVenta = this.Precio * this.Descuento;
            return PrecioVenta;
        }
    }
}
