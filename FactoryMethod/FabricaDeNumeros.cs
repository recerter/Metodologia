using System;
using System.Collections.Generic;
using System.Text;
using Metodologia.ChainOfResponsability;
using Metodologia.Estructura;

namespace Metodologia.FactoryMethod
{
    public class FabricaDeNumeros : FabricaDeComparables
    {
        public override Estructura.IComparable CrearAleatorio()
        {
            Manejadores generador = new LectorDeDatos(null);
            generador = GeneradorDeDatosAleatorios.getInstance(generador);
            generador = LectorDeArchivos.getInstance(generador);
            Numero registro = new Numero((int)generador.NumeroDesdeArchivo(9999));
            return registro;
        }

        public override Estructura.IComparable CrearPorTeclado()
        {
            Manejadores generador = new LectorDeDatos(null);
            generador = GeneradorDeDatosAleatorios.getInstance(generador);
            generador = LectorDeArchivos.getInstance(generador);
            Console.Write("Ingrese un numero: ");
            Numero registro = new Numero(generador.NumeroPorTeclado());
            return registro;
        }
    }
}
