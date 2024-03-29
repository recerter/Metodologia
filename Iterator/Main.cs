﻿using System;
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
            Estructura.Main.LlenarAlumnos(p);
            Estructura.Main.LlenarAlumnos(c);
            Estructura.Main.LlenarAlumnos(newconjunto);
            Estructura.Main.LlenarAlumnos(newdiccionario);
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
                Object elemento = (object)iter.Next();
                Console.WriteLine(elemento);
            }
        }

    }
}
