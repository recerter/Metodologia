using System;
using System.Collections.Generic;
using System.Text;
using Metodologia.ChainOfResponsability;
using Metodologia.Estructura;
using Metodologia.Proxy;

namespace Metodologia.FactoryMethod
{
    class FabricaDeAlumnosProxy : IFabricaDeComparables
    {
        public Estructura.IComparable CrearAleatorio()
        {
            Manejadores generador = new LectorDeDatos(null);
            generador = GeneradorDeDatosAleatorios.getInstance(generador);
            generador = LectorDeArchivos.getInstance(generador);
            return new AlumnoProxy(generador.StringAleatorio(6), (int)generador.NumeroAleatorio(990000), generador.NumeroAleatorio(99999), generador.NumeroAleatorio(10));
        }

        public Estructura.IComparable CrearPorTeclado()
        {
            Manejadores generador = new LectorDeDatos(null);
            generador = GeneradorDeDatosAleatorios.getInstance(generador);
            generador = LectorDeArchivos.getInstance(generador);
            Console.Write("\nIngrese un Nombre: ");
            string nombre = generador.StringPorTeclado();
            Console.Write("\nIngrese un Documento: ");
            int documento = generador.NumeroPorTeclado();
            Console.Write("\nIngrese un Legajo: ");
            int legajo = generador.NumeroPorTeclado();
            Console.Write("\nIngrese un Promedio: ");
            int promedio = generador.NumeroPorTeclado();

            return new AlumnoProxy(nombre, documento, legajo, promedio);
        }
    }
}