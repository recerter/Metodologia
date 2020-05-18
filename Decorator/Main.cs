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
            Student adaptado = new AdapterStudent((Alumno)new FabricaDeAlumnos().CrearAleatorio());
            DecoratorPorLegajo a = new DecoratorPorLegajo(adaptado);
            string imprimir = new DecoratorPorLegajo(adaptado).ImprimirDecorator();
            Console.Clear();
            Console.WriteLine(imprimir);
            Console.ReadKey();

            DecoratorPorNotaEnLetras b = new DecoratorPorNotaEnLetras(a.estudiante);
            imprimir = new DecoratorPorNotaEnLetras(adaptado).ImprimirDecorator();
            Console.Clear();
            Console.WriteLine(imprimir);
            Console.ReadKey();

            DecoratorPorPromocion c = new DecoratorPorPromocion(b.estudiante);
            imprimir = new DecoratorPorPromocion(adaptado).ImprimirDecorator();
            Console.Clear();
            Console.WriteLine(imprimir);
            Console.ReadKey();

            DecoratorPorRecuadroConAsteriscos d = new DecoratorPorRecuadroConAsteriscos(c.estudiante);
            imprimir = new DecoratorPorRecuadroConAsteriscos(adaptado).ImprimirDecorator();
            Console.Clear();
            Console.WriteLine(imprimir);
            Console.ReadKey();

            DecoratorPorRecuadroConAsteriscosCompleto e = new DecoratorPorRecuadroConAsteriscosCompleto(c.estudiante);
            imprimir = new DecoratorPorRecuadroConAsteriscosCompleto(adaptado).ImprimirDecorator();
            Console.Clear();
            Console.WriteLine(imprimir);
            Console.ReadKey();

            imprimir = e.ImprimirDecorator();
            Console.Clear();
            Console.WriteLine(imprimir);
            Console.ReadKey();
        }
    }
}
