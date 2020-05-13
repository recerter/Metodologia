using Metodologia.Estructura;
using System;
using System.Collections.Generic;
using System.Text;


namespace Metodologia.Strategy
{
    public interface IStrategyComparar
    {
        bool SosIgual(Estructura.IComparable a, Estructura.IComparable b);
        bool SosMenor(Estructura.IComparable a, Estructura.IComparable b);
        bool SosMayor(Estructura.IComparable a, Estructura.IComparable b);
    }
}
