using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public string Descripcion { get; set; }
        public decimal PVP { get; set; }
        public int Cantidad { get; set; }

        public Rubro rubro { get; set; }
        public UnidadMedida UnidadMedida { get; set; }
        public Marca Marca { get; set; }

        public const string categoriaA = "A";
        public const int stockMinimo = 100;

        // Campo , miembro de instancia
        public string CodBarras;
        // Campo de solo lectura  , miembro de clase
        public static readonly double Iva = 0.21;

        public Producto(string CodigoBarra)
        {
            CodBarras = CodigoBarra;
        }

        public Producto()
        {
            this.ID = 1;
            this.Descripcion = "Primer Producto";
            this.Precio = 1000;
        }


        public Producto(int pId, string pDescripcion, decimal pPrecio)
        {
            this.ID = pId;
            this.Descripcion = pDescripcion;
            this.Precio = pPrecio;
        }

        private int _id;
        public int ID
        {
            get { return _id; }
            set { _id = value; }

        }



        //private string _descripcion;
        //public string Descripcion
        //{
        //    get { return _descripcion; }
        //    set { _descripcion = value; }

        //}


        private decimal _dprecio;
        public decimal Precio
        {
            get { return _dprecio; }
            set { _dprecio = value; }

        }

        public Producto MostrarProducto()
        {
            this.ID = 1;
            this.Descripcion = "Primer Producto";
            this.Precio = 1000;

            return this;
        }

        public Producto MostrarProducto(int pId, string pDescripcion, decimal pPrecio)
        {
            this.ID = pId;
            this.Descripcion = pDescripcion;
            this.Precio = pPrecio;

            return this;
        }

        public static void MetodoEstatico()
        {
            Console.WriteLine("Esto es un metodo estatico");
        }

        public virtual string MostrarCategoria()
        {
            return "Producto Generico";
        }

        public void CambiarDescripcionRef(ref string pDescripcion)
        {
            pDescripcion = "Cambio Descripcion por Referencia";
        }

        public void CambiarDescripcionOut(out string pDescripcion)
        {
            pDescripcion = "Cambio Descripcion por Out";
        }


    }
}
