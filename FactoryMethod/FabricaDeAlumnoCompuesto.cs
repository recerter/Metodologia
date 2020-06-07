using Metodologia.ChainOfResponsability;
using Metodologia.Composite;
using Metodologia.Estructura;
using System;
using System.Collections.Generic;
using System.Text;

namespace Metodologia.FactoryMethod
{
    public class FabricaDeAlumnoCompuesto : IFabricaDeComparables
    {
        public Estructura.IComparable CrearAleatorio()
        {
            Manejadores generador = new LectorDeDatos(null);
            generador = GeneradorDeDatosAleatorios.getInstance(generador);
            generador = LectorDeArchivos.getInstance(generador);
            return new AlumnoCompuesto(generador.StringAleatorio(6), (int)generador.NumeroDesdeArchivo(990000), generador.NumeroAleatorio(99999), generador.NumeroAleatorio(10));
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
            Console.Write("\nIngrese un Calificacion: ");
            int calificacion = generador.NumeroPorTeclado();

            return new AlumnoCompuesto(nombre, documento, legajo, calificacion);
        }
    }
}
