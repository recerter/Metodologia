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

        public bool SosIgual(IComparable o)
        {
            return Estrategia.SosIgual(this, (Persona)o);
        }

        public bool SosMenor(IComparable o)
        {
            return Estrategia.SosMenor(this, (Persona)o);
        }

        public bool SosMayor(IComparable o)
        {
             return Estrategia.SosMayor(this, (Persona)o);
        }
       
    }
}
