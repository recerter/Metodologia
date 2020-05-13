using Metodologia.Estructura;
using System;
using System.Collections.Generic;
using System.Text;

namespace Metodologia.Strategy
{
    public class EstrategiaCompararLegajo:IStrategyComparar
    {
        public bool SosIgual(Alumno a, Alumno b)
        {
            return ((Alumno)a).Legajo == ((Alumno)b).Legajo;
        }

        public bool SosMayor(Alumno a, Alumno b)
        {
            return ((Alumno)a).Legajo > ((Alumno)b).Legajo;
        }

        public bool SosMenor(Alumno a, Alumno b)
        {
            return ((Alumno)a).Legajo < ((Alumno)b).Legajo;
        }
    }
}
