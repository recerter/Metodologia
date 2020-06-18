using System;
using System.Collections.Generic;
using System.Text;
using Metodologia.ChainOfResponsability;
using Metodologia.Estructura;

namespace Metodologia.FactoryMethod
{
    class FabricaDeAlumnoMuyEstudioso : FabricaDeComparables
    {
        public Estructura.IComparable CrearAleatorio()
        {
            Manejadores generador = new LectorDeDatos(null);
            generador = GeneradorDeDatosAleatorios.getInstance(generador);
            generador = LectorDeArchivos.getInstance(generador);
            AlumnoMuyEstudioso registro = new AlumnoMuyEstudioso(generador.StringAleatorio(6), (int)generador.NumeroDesdeArchivo(990000), generador.NumeroAleatorio(99999), generador.NumeroAleatorio(10));
            registro.Calificacion = generador.NumeroAleatorio(10);
            return registro;
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
            AlumnoMuyEstudioso registro = new AlumnoMuyEstudioso(nombre, documento, legajo, promedio);
            Console.Write("Por favor, ingrese una Calificacion: ");
            int calificacion = generador.NumeroPorTeclado();
            registro.Calificacion =calificacion;
            return registro;
        }
    }
}
