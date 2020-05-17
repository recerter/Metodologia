using System;
using System.Collections.Generic;
using System.Text;
using Metodologia.Estructura;

namespace Metodologia.FactoryMethod
{
    class FabricaDeVendedores : IFabricaDeComparables
    {
        public Estructura.IComparable CrearAleatorio()
        {
            GeneradorDeDatosAleatorios random = new GeneradorDeDatosAleatorios();
            return new Vendedor(random.StringAleatorio(10), Convert.ToInt32(random.NumeroAleatorio(99999)), Convert.ToDouble(random.NumeroAleatorio(99999)));
        }

        public Estructura.IComparable CrearPorTeclado()
        {
            Console.Write("Ingrese un Nombre: ");
            string nombre = new LectorDeDatos().StringPorTeclado();
            Console.Write("\nIngrese un Documento: ");
            int dni = new LectorDeDatos().NumeroPorTeclado();
            Console.Write("\nIngrese un Sueldo Basico: ");
            double sueldo = new LectorDeDatos().NumeroPorTeclado();
            Vendedor newVendedor = new Vendedor(nombre, dni, sueldo);
            return newVendedor;
        }
    }
}
