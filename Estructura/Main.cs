using System;
using System.Collections.Generic;
using System.Text;

namespace Metodologia.Estructura
{
    class Main
    {
        readonly static Random r = new Random(DateTime.Now.Millisecond);


        public static void Llenar(IColeccionable o)
        {
            for (int i = 0; i < 20; i++)
            {
                IComparable n = new Numero(r.Next(0, 100));
                o.Agregar(n);
            }
        }

        public static void Informar(IColeccionable o)
        {
            Console.WriteLine("Cant: " + o.Cuantos());
            Console.WriteLine("Min: " + o.Minimo());
            Console.WriteLine("Max: " + o.Maximo());
            IComparable c = new Numero(Int32.Parse(Console.ReadLine()));
            if (o.Contiene(c))
            {
                Console.WriteLine("El elemento leido esta en la coleccion");
            }
            else
            {
                Console.WriteLine("El elemento leido no esta en la coleccion");
            }

        }
        public static void InformarAlumno(IColeccionable o)
        {
            Console.WriteLine("Seleccione por que quiere comparar\n 1) Legajo \n 2) Dni ");
            int opcion = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Cant: " + o.Cuantos());
            if (opcion == 1)
            {
                Console.WriteLine("MinLegajo: " + o.Minimo());
                Console.WriteLine("MaxLegajo: " + o.Maximo());
            }
            else
            {
                Console.WriteLine("MinDNI: " + o.Minimo());
                Console.WriteLine("MaxDNI: " + o.Maximo());
            }

            IComparable c = new Numero(Int32.Parse(Console.ReadLine()));
            if (o.Contiene(c))
            {
                Console.WriteLine("El elemento leido esta en la coleccion");
            }
            else
            {
                Console.WriteLine("El elemento leido no esta en la coleccion");
            }

        }
        public static string RandomName()
        {
            Random obj = new Random();
            string posibles = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int longitud = posibles.Length;
            char letra;
            int longitudnuevacadena = 5;
            string nuevacadena = "";
            for (int i = 0; i < longitudnuevacadena; i++)
            {
                letra = posibles[obj.Next(longitud)];
                nuevacadena += letra.ToString();
            }
            return nuevacadena;
        }
        public static void LlenarPersonas(IColeccionable o)
        {
            for (int i = 0; i < 20; i++)
            {
                IComparable d = new Persona(RandomName(), r.Next(0, 100));
                o.Agregar(d);
            }
        }
        public static void LlenarAlumnos(IColeccionable o)
        {
            for (int i = 0; i < 20; i++)
            {
                IComparable d = new Alumno(RandomName(), r.Next(0, 10000), r.Next(0, 1000), r.Next(0, 10));
                o.Agregar(d);
            }
        }
    }
}
