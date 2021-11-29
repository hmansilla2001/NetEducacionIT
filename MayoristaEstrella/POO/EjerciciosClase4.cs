using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class EjerciciosClase4
    {
        enum Color
        {
            Rojo = 1,
            Verde = 2,
            Azul = 4,
            Negro = 0,
            Blanco = Rojo | Verde | Azul
        }

        public void Colecciones()
        {
            // Crea un objeto de tipo lista de enteros
            List<int> lista = new List<int>();

            // agregar elementos a una lista
            lista.Add(40);
            lista.Add(25);
            lista.Add(35);
            lista.Add(54);
            lista.Add(84);

            // Recorrer lista
            // foreach
            Console.WriteLine("Mostrar Lista con foreach");
            int j = 0;
            foreach (var item in lista)
            {
                Console.WriteLine("Posicion " + j + ": " +  item);
               j++;
            }

            // For
            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine("Posicion {0}: {1}", i, lista[i]);
            }

            List<Producto> listaProductosOld = new List<Producto>();
            Producto producto = new Producto();
            producto.Descripcion = "mi producto 1";
            listaProductosOld.Add(producto);

            producto = new Producto();
            producto.Descripcion = "mi producto 2";
            listaProductosOld.Add(producto);

            producto = new Producto();
            producto.Descripcion = "mi producto 3";
            listaProductosOld.Add(producto);

            foreach (var item in listaProductosOld)
            {
                Console.WriteLine(item.Descripcion);
            }

            List<Producto> listaProductos = new List<Producto>();
            listaProductos.Add(new Producto(1, "Test 1", 1000));
            listaProductos.Add(new Producto(2, "Test 2", 2000));
            listaProductos.Add(new Producto(3, "Test 3", 3000));
            listaProductos.Add(new Producto(3, "Test 3", 4000));
            Console.WriteLine("lista de productos cargados con constructor");
            foreach (var item in listaProductos)
            {
                Console.WriteLine(item.Descripcion);
            }

            Console.WriteLine("Lista de string inicializada");
            var productos = new List<string> { "Producto 1", "Producto 2", "Producto 1", "Producto 4" };
            foreach (var item in productos)
            {
                Console.WriteLine(item);
            }

          //  Console.WriteLine("Lista de string sin un elemento");
            //productos.Remove("Producto 1");
            //foreach (var item in productos)
            //{
            //    Console.WriteLine(item);
            //}
            for (int i = 0; i < productos.Count; i++)
            {
                if (productos[i] == "Producto 1")
                {
                    productos.Remove(productos[i]);
                }
            }
            Console.WriteLine("Lista de string sin elementos Producto 1");
            foreach (var item in productos)
            {
                Console.WriteLine(item);
            }

            

            decimal sumaPrecios = listaProductos.Sum(x => x.Precio);
            decimal promedio = sumaPrecios / listaProductos.Count;
            Console.WriteLine("suma: " + sumaPrecios);
            Console.WriteLine("Cantidad: " + listaProductos.Count);
            Console.WriteLine("Promedio: " + promedio);

            // Eliminar por indice
            //listaProductos.RemoveAt(0);
            //Console.WriteLine("lista de productos sin el primer elemento");
            //foreach (var item in listaProductos)
            //{
            //    Console.WriteLine(item.Descripcion);
            //}

            // sumaPrecios = listaProductos.Sum(x => x.Precio);
            // promedio = sumaPrecios / listaProductos.Count;
            //Console.WriteLine("suma: " + sumaPrecios);
            //Console.WriteLine("Cantidad: " + listaProductos.Count);
            //Console.WriteLine("Promedio: " + promedio);
            foreach (var item in listaProductos)
            {
                Console.WriteLine(item.Descripcion);
                Console.WriteLine(item.Precio);
            }
            for (int i = listaProductos.Count - 1 ; i >= 0; i--)
            {
                if (listaProductos[i].Precio > 2000)
                {
                    listaProductos.RemoveAt(i);
                }
            }

            foreach (var item in listaProductos)
            {
                Console.WriteLine(item.Descripcion);
                Console.WriteLine(item.Precio);
            }
            sumaPrecios = listaProductos.Sum(x => x.Precio);
            promedio = sumaPrecios / listaProductos.Count;
            Console.WriteLine("suma: " + sumaPrecios);
            Console.WriteLine("Cantidad: " + listaProductos.Count);
            Console.WriteLine("Promedio: " + promedio);

            // lista de objetos cargada por clase
            var listaproductos2 = new List<Producto>
            {
                new Producto() { ID=1, Descripcion="Producto 1", Precio=1000 },
                new Producto() { ID=1, Descripcion="Producto 1", Precio=1000 },
                new Producto() { ID=1, Descripcion="Producto 1", Precio=1000 }
            };

            foreach (var item in listaproductos2)
            {
                Console.WriteLine(item.Descripcion);
                Console.WriteLine(item.Precio);
            }


            //// Iterar la lista
            //// Mediante una expresión lambda un Foreach es colocado en el objeto List(T).
            Console.WriteLine("Lista de  productos cargada con expresion lambda");
            productos.ForEach(
            producto1 => Console.Write(producto1 + " "));

            // ordenar listas de objetos
           // listaProductos.OrderByDescending(X => X.Descripcion);
           // listaProductos.OrderBy(X => X.Descripcion);

            //Console.WriteLine("Lista de  numeros ordenada");
            lista.Sort();
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }

            //Console.WriteLine("Lista de  numeros reversa");
            lista.Reverse();
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }

            //// Add range permite agregar una lista (rango) dentro de otra
            Console.WriteLine("Lista de  productos con listaproductos, listaproductos1 y listaproductosold");

            List<Producto> listaCompleta = new List<Producto>();
            listaCompleta.AddRange(listaProductos);
            listaCompleta.AddRange(listaproductos2);
            listaCompleta.AddRange(listaProductosOld);
            List<ProductoPrincipal> listaprincipal = new List<ProductoPrincipal>();
            listaprincipal.Add(new ProductoPrincipal());
            listaCompleta.AddRange(listaprincipal);

            foreach (var item in listaCompleta)
            {
                Console.WriteLine(item.Descripcion);
                Console.WriteLine(item.Precio);
            }


            List<object> miListaGenerica = new List<object>();

            Producto p = new Producto();
            EjerciciosClase2 e = new EjerciciosClase2();
            EjerciciosClase3 e3 = new EjerciciosClase3();

            miListaGenerica.Add(p);
            miListaGenerica.Add(e);
            miListaGenerica.Add(e3);

            foreach (var item in miListaGenerica)
            {
                if (item.GetType() == p.GetType())
                {
                    Console.WriteLine(((Producto)p).Descripcion);
                }
            }

            //productos.AddRange(productos);

            //Console.WriteLine();
            //foreach (string producto1 in productos)
            //{
            //    Console.WriteLine(producto1);
            //}

        }
        public void Enumeradores()
        {
            MetodoEnum(Color.Blanco);
        }

        private void MetodoEnum(Color colorEnum)
        {
            Console.WriteLine("El color {0}, es {1}", (int)colorEnum, colorEnum);
        }


        public void EjemploEstaticaVirtualAbstractSealed()
        {
            // clase y metodo estatico
            double montoMasIva = Calculos.SumarIva(1000);
            Console.WriteLine("el monto mas iva es {0} ", montoMasIva);


            // invoca metodo sobreescrito 
            FacturaA facturaA = new FacturaA();
            // facturaA.VerTotal();
            Console.WriteLine("El valor total es {0} ", facturaA.VerTotal());

            // invoca metodo implementado
            facturaA.GenerarFactura();

            Banco banco = new Banco();
            banco.Veraz();

        }

        public void UsoInterfaces()
        {
            FacturaA factura = new FacturaA();

            factura.GenerarFacturaArgentina();

            Console.WriteLine("El monto es {0}", factura.CalcularIVA(1000));
        }



    }
}
