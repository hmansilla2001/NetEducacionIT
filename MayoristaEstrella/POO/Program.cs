using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using POO.MisClases;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 c = new Class1();
            c.prueba = 1;
            MiClaseEspecial p = new MiClaseEspecial();

            //EjerciciosClase2 ejerciciosClase2 = new EjerciciosClase2();

            //ejerciciosClase2.EjercicioEstructuras();
            //ejerciciosClase2.EjercicioEnumeradores();
            //ejerciciosClase2.EjerciciosMetodosConstructores();
            //EjerciciosClase3 ejercicios = new EjerciciosClase3();
            //ejercicios.Constantes();
            //ejercicios.Campos();
            //ejercicios.MetodosOutRef();
            //ejercicios.MetodoEstatico();
            //ejercicios.Conversiones();

            EjerciciosClase4 clase4 = new EjerciciosClase4();
       //     clase4.Colecciones();
            clase4.EjemploEstaticaVirtualAbstractSealed();
            Console.ReadKey();

        }

    }

}
