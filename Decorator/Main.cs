using System;
using System.Collections.Generic;
using System.Text;
using Metodologia.Estructura;
using Metodologia.FactoryMethod;
using Metodologia.Adapter;

namespace Metodologia.Decorator
{
    public class Main
    {
        public static void Run()
        {
            Alumno adaptado = (Alumno)new FabricaDeAlumnos().CrearAleatorio();
            Alumno a = new DecoratorPorLegajo(adaptado);
            
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
