﻿using System;
using System.Collections.Generic;
using System.Text;
using Metodologia.Estructura;
using Metodologia.Iterator;

namespace Metodologia.Strategy
{
    class Main
    {

        public static void Run()
        {
            Pila p = new Pila();
            Estructura.Main.LlenarAlumnos(p);
            Console.WriteLine("Nombre");
            CambiarEstrategia(p, new EstrategiaCompararNombre());
            Estructura.Main.Informar(p);
            Console.WriteLine("Legajo");
            CambiarEstrategia(p, new EstrategiaCompararLegajo());
            Estructura.Main.Informar(p);
            Console.WriteLine("Promedio");
            CambiarEstrategia(p, new EstrategiaCompararPromedio());
            Estructura.Main.Informar(p);
            Console.WriteLine("Dni");
            CambiarEstrategia(p, new EstrategiaCompararDni());
            Estructura.Main.Informar(p);
        }
        public static void CambiarEstrategia(IColeccionable alumnos, IStrategyComparar estrategia)
        {
            IIteradorColeccion iter = alumnos.CrearIterador();

            while (!iter.End())
            {
                Alumno unaPersona = (Alumno)iter.Next();
                unaPersona.Estrategia = estrategia;
            }
        }
    }
}
