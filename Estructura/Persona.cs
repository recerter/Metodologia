using System;
using System.Collections.Generic;
using System.Text;
using Metodologia.Iterator;
using Metodologia.Strategy;

namespace Metodologia.Estructura
{
    public class Persona :IComparable
    {
        private string nombre;
        private int dni;
        private IStrategyComparar estrategia;

        public Persona(string nombre, int dni)
        {
            this.nombre = nombre;
            this.dni = dni;
            Estrategia = new EstrategiaCompararNombre();
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        public int Dni
        {
            get
            {
                return this.dni;
            }
            set
            {
                this.dni = value;
            }
        }
        public IStrategyComparar Estrategia
        {
            get
            {
                return this.estrategia;
            }
            set
            {
                this.estrategia = value;
            }
        }
        public Persona()
        {
            Estrategia = new EstrategiaCompararNombre();
        }

        public bool SosIgual(object o)
        {
            Persona n = o as Persona;
            return Dni == n.Dni;
        }

        public bool SosMenor(object o)
        {
            Persona n = o as Persona;
            return Dni < n.Dni;
        }

        public bool SosMayor(object o)
        {
            Persona n = o as Persona;
            return Dni > n.Dni;
        }
        public override string ToString()
        {
            return string.Format("[Persona Nombre={0} DNI= {1}]", nombre, dni);
        }
    }
}
