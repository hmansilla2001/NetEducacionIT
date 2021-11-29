using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public sealed class Banco:Factura
    {
        public override void GenerarFactura()
        {
            Console.WriteLine("Implementacion Final");
        }

        public  void Veraz()
        {
            Console.WriteLine("No se puede heredar el comportamiento de sus miembros");
        }
    }
}
