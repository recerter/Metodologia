using System;
using System.Collections.Generic;
using System.Text;
using Metodologia.Estructura;
using Metodologia.ChainOfResponsability;

namespace Metodologia.FactoryMethod
{
    public class FabricaDeAlumnos : FabricaDeComparables
    {
        public Estructura.IComparable CrearAleatorio()
        {
            Manejadores generador = new LectorDeDatos(null);
            generador = GeneradorDeDatosAleatorios.getInstance(generador);
            return new Alumno(generador.StringAleatorio(6), (int)generador.NumeroDesdeArchivo(990000), generador.NumeroAleatorio(99999), generador.NumeroAleatorio(10));
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

            return new Alumno(nombre, documento, legajo, promedio);
        }
    }
}
