using Metodologia.ChainOfResponsability;
using Metodologia.Composite;
using Metodologia.Estructura;
using System;
using System.Collections.Generic;
using System.Text;

namespace Metodologia.FactoryMethod
{
    public class FabricaDeAlumnoCompuesto : FabricaDeComparables
    {
        FabricaDeAlumnoCompuesto(string nombre, int dni, int legajo, int calificacion)
        {

        }
        public Estructura.IComparable CrearAleatorio()
        {
            return new AlumnoCompuesto(generador.StringAleatorio(6), (int)generador.NumeroDesdeArchivo(990000), generador.NumeroAleatorio(99999), generador.NumeroAleatorio(10));
        }

        public override Estructura.IComparable CrearComparable()
        {
            throw new NotImplementedException();
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

        public override Estructura.IComparable CrearPorTeclado()
        {
            throw new NotImplementedException();
        }
    }
}
