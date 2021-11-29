using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ProductoPrincipal : Producto
    {

        public ProductoPrincipal()
             : base(3, "producto principal", 10000)
        {
            this.Material = "Plastico";
            this.Color = "Verde";
        }

        public ProductoPrincipal(string material , string color)
            :base(3, "producto principal", 10000)
        {
            this.Material = material;
            this.Color = color;
        }

        public string Material { get; set; }
        public string Color { get; set; }

        public string DescripcionCompleta => Material + " - " + Color;

        public override string MostrarCategoria()
        {
            return "Producto principal";
        }

    }
}
