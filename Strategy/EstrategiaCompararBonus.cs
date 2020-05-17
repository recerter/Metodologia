using System;
using System.Collections.Generic;
using System.Text;
using Metodologia.Estructura;

namespace Metodologia.Strategy
{
    class EstrategiaCompararBonus : IStrategyComparar
    {
        public bool SosIgual(Estructura.IComparable a, Estructura.IComparable b)
        {
            return ((Vendedor)b).Bonus.Equals(((Vendedor)a).Bonus) ? true : false;
        }

        public bool SosMayor(Estructura.IComparable a, Estructura.IComparable b)
        {
            return ((Vendedor)b).Bonus > ((Vendedor)a).Bonus ? true : false;
        }

        public bool SosMenor(Estructura.IComparable a, Estructura.IComparable b)
        {
            return ((Vendedor)b).Bonus < ((Vendedor)a).Bonus ? true : false;
        }
    }
}
