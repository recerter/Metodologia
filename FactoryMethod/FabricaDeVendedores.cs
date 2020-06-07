using System;
using System.Collections.Generic;
using System.Text;
using Metodologia.ChainOfResponsability;
using Metodologia.Estructura;

namespace Metodologia.FactoryMethod
{
    public class FabricaDeVendedores : IFabricaDeComparables
    {
        public Estructura.IComparable CrearAleatorio()
        {
            Manejadores generador = new LectorDeDatos(null);
            generador = GeneradorDeDatosAleatorios.getInstance(generador);
            generador = LectorDeArchivos.getInstance(generador);
            return new Vendedor(generador.StringDesdeArchivo(10), generador.NumeroAleatorio(420000), generador.NumeroDesdeArchivo(6000));
        }

        public Estructura.IComparable CrearPorTeclado()
        {
            Manejadores generador = new LectorDeDatos(null);
            generador = GeneradorDeDatosAleatorios.getInstance(generador);
            generador = LectorDeArchivos.getInstance(generador);
            Console.Write("Ingrese un Nombre: ");
            string nombre = generador.StringPorTeclado();
            Console.Write("\nIngrese un Documento: ");
            int dni = generador.NumeroPorTeclado();
            Console.Write("\nIngrese un Sueldo Basico: ");
            double sueldo = generador.NumeroPorTeclado();
            return new Vendedor(nombre, dni, sueldo);
        }
    }
}
