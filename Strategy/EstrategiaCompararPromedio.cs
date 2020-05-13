using Metodologia.Estructura;
using System;
using System.Collections.Generic;
using System.Text;

namespace Metodologia.Strategy
{
    public class EstrategiaCompararPromedio:IStrategyComparar
    {
        public bool SosIgual(Alumno a, Alumno b)
        {
            return ((Alumno)a).Promedio == ((Alumno)b).Promedio;
        }

        public bool SosMayor(Alumno a, Alumno b)
        {
            return ((Alumno)a).Promedio > ((Alumno)b).Promedio;
        }

        public bool SosMenor(Alumno a, Alumno b)
        {
            return ((Alumno)a).Promedio < ((Alumno)b).Promedio;
        }
    }
}
