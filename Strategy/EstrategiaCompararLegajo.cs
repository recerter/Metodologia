using Metodologia.Estructura;
using System;
using System.Collections.Generic;
using System.Text;

namespace Metodologia.Strategy
{
    public class EstrategiaCompararLegajo:IStrategyComparar
    {
        public bool SosIgual(Estructura.IComparable a, Estructura.IComparable b)
        {
            return ((Alumno)a).Legajo == ((Alumno)b).Legajo;
        }

        public bool SosMayor(Estructura.IComparable a, Estructura.IComparable b)
        {
            return ((Alumno)a).Legajo > ((Alumno)b).Legajo;
        }

        public bool Sosmenor(Estructura.IComparable a, Estructura.IComparable b)
        {
            return ((Alumno)a).Legajo < ((Alumno)b).Legajo;
        }
    }
}
