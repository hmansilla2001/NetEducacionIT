using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{

    public struct PrecioVenta
    {
        public decimal precio, ganancia;
        public PrecioVenta (decimal Precio, decimal Ganancia)
        {
            this.precio = Precio;
            this.ganancia = Ganancia;
        }


    }

    class EjerciciosClase2
    {


        enum Estado { Deshabilitado, Habilitado }

        enum Color
        {
            Rojo = 1,
            Verde = 2,
            Azul = 4,
            Negro = 0,
            Blanco = Rojo | Verde | Azul

        }

        public void EjercicioEstructuras()
        {
            Console.WriteLine("Estructuras");
            Console.WriteLine();

            PrecioVenta pv = new PrecioVenta(1000, 200);

            decimal precioVenta = pv.precio + pv.ganancia;

            Console.WriteLine("El precio de lista es " + pv.precio);

            Console.WriteLine("La ganancia debe ser de " + pv.ganancia);

            Console.WriteLine("El precio de venta es " + precioVenta);

            Console.ReadKey();

        }

        public void EjercicioEnumeradores()
        {
            Console.WriteLine("Enumeradores");
            Console.WriteLine();

            Color c = Color.Negro;
            Console.WriteLine((int)c); // 0
            Console.WriteLine(c.ToString()); // Negro
            Console.WriteLine(c); // Negro
            Console.WriteLine();


            Color x = Color.Blanco;
            Console.WriteLine((int)x); // 7
            Console.WriteLine(x.ToString()); // Blanco
            Console.WriteLine(x); // Blanco
            Console.WriteLine();

            Estado y =  Estado.Habilitado;
            Console.WriteLine((int)y); // 1
            Console.WriteLine(y.ToString()); // Habilitado
            Console.WriteLine(y); // Habilitado
            Console.ReadKey();
        }


        public void EjerciciosMetodosConstructores()
        {
            Producto producto1 = new Producto();
            Console.WriteLine("Inicializacion del producto: ID: {0} , Descripcion: {1} , Precio: {2}", producto1.ID, producto1.Descripcion, producto1.Precio);

            producto1 = producto1.MostrarProducto();
            Console.WriteLine("Inicializacion del producto: ID: {0} , Descripcion: {1} , Precio: {2}", producto1.ID, producto1.Descripcion, producto1.Precio);

            producto1.MostrarProducto(2, "otro producto", 1000);
            Console.WriteLine("Inicializacion del producto: ID: {0} , Descripcion: {1} , Precio: {2}", producto1.ID, producto1.Descripcion, producto1.Precio);



            Producto producto2 = new Producto(3, "otro producto", 5000);
            Console.WriteLine("Inicializacion del producto: ID: {0} , Descripcion: {1} , Precio: {2}", producto2.ID, producto2.Descripcion, producto2.Precio);

            Console.WriteLine(producto2.ToString());

            ProductoPrincipal productoPrincipal = new ProductoPrincipal();
            Console.WriteLine("Inicializacion del producto principal Material: {0} , Color: {1}", productoPrincipal.Material, productoPrincipal.Color);

            ProductoPrincipal productoPrincipal2 = new ProductoPrincipal("Tela", "Rojo");

            Console.WriteLine("Inicializacion del producto principal Material: {0} , Color: {1}", productoPrincipal2.Material, productoPrincipal2.Color);

            ProductoSecundario productoSecundario = new ProductoSecundario(3,"otro producto", 1000);

            Console.WriteLine("Inicializacion del producto secundario: ID: {0} , Descripcion: {1} , Precio: {2}", productoSecundario.ID, productoSecundario.Descripcion, productoSecundario.Precio);



            Console.ReadKey();

        }


    }
}
