using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ProductoSecundario : Producto
    {
        public decimal AltoEnMetros { get; set; }
        public decimal AnchoEnMetros { get; set; }

        public ProductoSecundario (int pID, string pDescripcion, decimal pPrecio)
            :base(pID, pDescripcion,pPrecio)

        {
            this.AltoEnMetros = 100;
            this.AnchoEnMetros = 5;
        }


        public override string MostrarCategoria()
        {
            return  base.MostrarCategoria() + " - " + "Producto Secundario";
        }
    }

  
}
