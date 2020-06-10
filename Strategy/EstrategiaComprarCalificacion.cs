using Metodologia.Estructura;
using System;
using System.Collections.Generic;
using System.Text;

namespace Metodologia.Strategy
{
    public class EstrategiaComprarCalificacion : IStrategyComparar
    {
        public bool SosIgual(Estructura.IComparable a, Estructura.IComparable b)
        {
            return ((Alumno)a).Calificacion == ((Alumno)b).Calificacion;
        }

        public bool SosMayor(Estructura.IComparable a, Estructura.IComparable b)
        {
            return ((Alumno)a).Calificacion > ((Alumno)b).Calificacion;
        }

        public bool SosMenor(Estructura.IComparable a, Estructura.IComparable b)
        {
            return ((Alumno)a).Calificacion < ((Alumno)b).Calificacion;
        }
    }
}
