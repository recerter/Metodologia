using Metodologia.ChainOfResponsability;
using Metodologia.Estructura;
using Metodologia.TemplateMethod;
using System;
using System.Collections.Generic;
using System.Text;

namespace Metodologia.FactoryMethod
{
    public class FabricaDeJugadores
    {
        public Estructura.IComparable CrearAleatorio()
        {
            Manejadores generador = new LectorDeDatos(null);
            generador = GeneradorDeDatosAleatorios.getInstance(generador);
            return new Jugador(generador.StringAleatorio(6), (int)generador.NumeroDesdeArchivo(990000));
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

            return new Jugador(nombre, documento);
        }
    }
}
