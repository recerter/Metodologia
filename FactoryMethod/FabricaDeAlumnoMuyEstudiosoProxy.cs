using Metodologia.ChainOfResponsability;
using Metodologia.Estructura;
using Metodologia.Proxy;
using System;
using System.Collections.Generic;
using System.Text;

namespace Metodologia.FactoryMethod
{
    class FabricaDeAlumnoMuyEstudiosoProxy : FabricaDeComparables
    {
        public Estructura.IComparable CrearAleatorio()
        {
            Manejadores generador = new LectorDeDatos(null);
            generador = GeneradorDeDatosAleatorios.getInstance(generador);
            generador = LectorDeArchivos.getInstance(generador);
            AlumnoMuyEstudiosoProxy registro = new AlumnoMuyEstudiosoProxy(generador.StringAleatorio(6), generador.NumeroAleatorio(99999), generador.NumeroAleatorio(99999), generador.NumeroAleatorio(10));
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
            AlumnoMuyEstudiosoProxy registro = new AlumnoMuyEstudiosoProxy(nombre, documento, legajo, promedio);
            Console.Write("Por favor, ingrese una Calificacion: ");
            int calificacion = generador.NumeroPorTeclado();
            registro.Calificacion = calificacion;
            return registro;
        }
    }
}
