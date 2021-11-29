using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public  abstract class Factura 
    {
       public abstract void GenerarFactura();

        public virtual int VerTotal()
        {
            return 1000;
        }

        public void MetodoClasico()
        {
            Console.WriteLine("Metodo clasico en clase abstracta");
        }
    }
}
