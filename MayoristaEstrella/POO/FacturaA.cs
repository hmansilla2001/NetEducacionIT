using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class FacturaA : Factura,IRegionArgentina,IFacturaBuenosAires
    {

        // se debe implementar el metodo abstracto Generar Factura
        public override void GenerarFactura()
        {
            Console.WriteLine("Factura A");
        }

        //// puede o no sobreescribirse el metodo
        //public override int VerTotal()
        //{
        //    return base.VerTotal() + 1000;
        //}

        // implemente metodo de interface
        public void GenerarFacturaArgentina()
        {
            Console.WriteLine("Factura de Argentina");
        }
        // implementa metodo de interface
        public double CalcularIVA(double monto)
        {
            return monto * 1.21;
        }

        public void GenerarFacturaRegionArgentina()
        {
            Console.WriteLine("Factura Region Argentina");
        }

        public void GenerarFacuraBaires()
        {
            Console.WriteLine("Factura Buenos Aires");
        }
    }
}
