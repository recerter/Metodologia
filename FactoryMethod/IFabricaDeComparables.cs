using System;
using System.Collections.Generic;
using System.Text;
using Metodologia.Estructura;

namespace Metodologia.FactoryMethod
{
    public interface IFabricaDeComparables
    {
        public Estructura.IComparable CrearAleatorio();
        public Estructura.IComparable CrearPorTeclado();
    }
}
