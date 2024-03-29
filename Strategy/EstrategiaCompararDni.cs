﻿using Metodologia.Estructura;
using System;
using System.Collections.Generic;
using System.Text;

namespace Metodologia.Strategy
{
    public class EstrategiaCompararDni : IStrategyComparar
    {
        public bool SosIgual(Estructura.IComparable a, Estructura.IComparable b)
        {
            return ((Alumno)a).Dni == ((Alumno)b).Dni;
        }

        public bool SosMayor(Estructura.IComparable a, Estructura.IComparable b)
        {
            return ((Alumno)a).Dni > ((Alumno)b).Dni;
        }

        public bool SosMenor(Estructura.IComparable a, Estructura.IComparable b)
        {
            return ((Alumno)a).Dni < ((Alumno)b).Dni;
        }
    }
}
