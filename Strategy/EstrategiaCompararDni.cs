using Metodologia.Estructura;
using System;
using System.Collections.Generic;
using System.Text;

namespace Metodologia.Strategy
{
    public class EstrategiaCompararDni : IStrategyComparar
    {
        public bool SosIgual(Alumno a, Alumno b)
        {
            return ((Alumno)a).Dni == ((Alumno)b).Dni;
        }

        public bool SosMayor(Alumno a, Alumno b)
        {
            return ((Alumno)a).Dni > ((Alumno)b).Dni;
        }

        public bool SosMenor(Alumno a, Alumno b)
        {
            return ((Alumno)a).Dni < ((Alumno)b).Dni;
        }
    }
}
