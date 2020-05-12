using Metodologia.Estructura;
using System;
using System.Collections.Generic;
using System.Text;

namespace Metodologia.Strategy
{
    public class EstrategiaCompararNombre:IStrategyComparar
    {
        public bool SosIgual(Estructura.IComparable a, Estructura.IComparable b)
        {
            return ((Persona)a).Nombre == ((Persona)b).Nombre;
        }

        public bool SosMayor(Estructura.IComparable a, Estructura.IComparable b)
        {
            return ((Persona)b).Nombre.CompareTo(((Persona)a).Nombre) > 0 ? true : false;
        }

        public bool Sosmenor(Estructura.IComparable a, Estructura.IComparable b)
        {
            return ((Persona)b).Nombre.CompareTo(((Persona)a).Nombre) < 0 ? true : false;
        }
    }
}
