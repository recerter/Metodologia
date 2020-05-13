using Metodologia.Estructura;
using System;
using System.Collections.Generic;
using System.Text;

namespace Metodologia.Strategy
{
    public interface IStrategyComparar
    {
        bool SosIgual(Alumno a, Alumno b);
        bool SosMenor(Alumno a, Alumno b);
        bool SosMayor(Alumno a, Alumno b);
    }
}
