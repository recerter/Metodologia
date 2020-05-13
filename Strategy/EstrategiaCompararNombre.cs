using Metodologia.Estructura;
using System;
using System.Collections.Generic;
using System.Text;

namespace Metodologia.Strategy
{
    public class EstrategiaCompararNombre:IStrategyComparar
    {
        public bool SosIgual(Alumno a, Alumno b)
        {
            return a.Nombre == b.Nombre;
        }

        public bool SosMayor(Alumno a, Alumno b)
        {
            return b.Nombre.CompareTo(a.Nombre) > 0 ? true : false;
        }

        public bool SosMenor(Alumno a, Alumno b)
        {
            return b.Nombre.CompareTo(a.Nombre) < 0 ? true : false;
        }
    }
}
