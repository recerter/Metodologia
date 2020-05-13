using System;
using System.Collections.Generic;
using System.Text;
using Metodologia.Estructura;

namespace Metodologia.Iterator
{
    class Main
    {
        public static void Run()
        {
            Pila p = new Pila();
            Cola c = new Cola();
            Conjunto newconjunto = new Conjunto();
            Diccionario newdiccionario = new Diccionario();
            Estructura.Main.llenarAlumnos(p);
            Estructura.Main.llenarAlumnos(c);
            Estructura.Main.llenarAlumnos(newconjunto);
            Estructura.Main.llenarAlumnos(newdiccionario);
            Console.WriteLine("Imprime Pila");
            ImprimirElementos(p);
            Console.WriteLine("Imprime Cola");
            ImprimirElementos(c);
            Console.WriteLine("Imprime Conjunto");
            ImprimirElementos(newconjunto);
            Console.WriteLine("Imprime Diccionario");
            ImprimirElementos(newdiccionario);
        }
        
        public static void ImprimirElementos(IColeccionable coleccion)
        {
            IIteradorColeccion iter = coleccion.CrearIterador();
            while (!iter.End())
            {
                Alumno elemento = (Alumno)iter.Next();
                Console.WriteLine("Alumno: {0}\tDNI: {1}\tLegajo: {2}\tPromedio: {3}",
                     elemento.Nombre, elemento.Dni, elemento.Legajo, elemento.Promedio);
            }
        }
    }
}
