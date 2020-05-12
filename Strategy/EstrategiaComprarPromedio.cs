﻿using Metodologia.Estructura;
using System;
using System.Collections.Generic;
using System.Text;

namespace Metodologia.Strategy
{
    public class EstrategiaComprarPromedio:IStrategyComparar
    {
        public bool SosIgual(Estructura.IComparable a, Estructura.IComparable b)
        {
            return ((Alumno)a).Promedio == ((Alumno)b).Promedio;
        }

        public bool SosMayor(Estructura.IComparable a, Estructura.IComparable b)
        {
            return ((Alumno)a).Promedio > ((Alumno)b).Promedio;
        }

        public bool Sosmenor(Estructura.IComparable a, Estructura.IComparable b)
        {
            return ((Alumno)a).Promedio < ((Alumno)b).Promedio;
        }
    }
}
