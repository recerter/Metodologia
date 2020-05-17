using System;
using System.Collections.Generic;
using System.Text;
using Metodologia.Estructura;

namespace Metodologia.FactoryMethod
{
    class FabricaDeNumeros : IFabricaDeComparables
    {
        public Estructura.IComparable CrearAleatorio()
        {
            Random rnd = new Random();
            return new Numero(rnd.Next());
        }

        public Estructura.IComparable CrearPorTeclado()
        {
            Console.Write("Ingrese un Numero: ");
            int usuario = Convert.ToInt32(Console.ReadLine());
            return new Numero(usuario);
        }
    }
}
