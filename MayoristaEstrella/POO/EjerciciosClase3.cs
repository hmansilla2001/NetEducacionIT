using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
namespace POO
{
    public class EjerciciosClase3
    {
        public void Constantes()
        {
            Console.WriteLine("Constante Categoria: " + Producto.categoriaA);
            Console.WriteLine("Constante StockMinimo: " + Producto.stockMinimo);


        }

        public void Campos()
        {
            Producto MiProducto = new Producto("EstoEsUnCodigoDeBarras");
            Console.WriteLine("Campo de Codigo de Barras: " + MiProducto.CodBarras);

            Console.WriteLine("Iva: " + Producto.Iva);

        }

        public void MetodosOutRef()
        {
            string descripcion = "descripcion1";
            Console.WriteLine("descripcion inicial " + descripcion);
            Producto producto1 = new Producto();
            producto1.CambiarDescripcionRef(ref descripcion);
            Console.WriteLine("descripcion modificada por referencia " + descripcion);

            descripcion = string.Empty;
            Console.WriteLine("descripcion vacia " + descripcion);
            producto1.CambiarDescripcionOut(out descripcion);
            Console.WriteLine("descripcion modificada por out " + descripcion);




        }

        public void MetodoEstatico()
        {
            Producto.MetodoEstatico();
        }

        public void Conversiones()
        {

            int t;
            double p = 3.14;
            string FechaTexto = "03/03/2020";
            DateTime fecha;

            // Explicita
            t = (int)p;
            Console.WriteLine("Variable convertida a entero de manera explicita " + t);

            fecha = Convert.ToDateTime(FechaTexto);
            Console.WriteLine("Variable convertida a Fecha de manera explicita " + fecha.ToString());

            // Implicita
            p = t;
            Console.WriteLine("Variable convertida a double de manera implicita " + t);

            // Implicita derivada
            Producto producto;
            ProductoPrincipal productoPrincipal = new ProductoPrincipal();
            productoPrincipal.Descripcion = "Producto principal";
            producto = productoPrincipal;

            Console.WriteLine("Producto covertido por conversion implicita dervada " + producto.Descripcion);
        }
    }
}
