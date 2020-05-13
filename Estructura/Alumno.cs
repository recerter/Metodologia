using Metodologia.Strategy;
using System;
using System.Collections.Generic;
using System.Text;


namespace Metodologia.Estructura
{
    public class Alumno:Persona, IComparable
    {
        private int legajo;
        private int promedio;

        public Alumno(string nombre, int dni, int legajo, int promedio) : base(nombre, dni)
        {
            this.legajo = legajo;
            this.promedio = promedio;
            base.Estrategia = new EstrategiaCompararNombre();
        }

        public int Legajo
        {
            get
            {
                return this.legajo;
            }
            set
            {
                this.legajo = value;
            }
        }
        public int Promedio
        {
            get
            {
                return this.promedio;
            }
            set
            {
                this.promedio = value;
            }
        }

        public bool SosIgual(Persona comparable)
        {
            return Estrategia.SosIgual(this, comparable);
        }

        public bool SosMenor(Persona comparable)
        {
            return Estrategia.SosMenor(this, comparable);
        }

        public bool SosMayor(Persona comparable)
        {
            return Estrategia.SosMayor(this, comparable);
        }

        public override string ToString()
        {
            return string.Format("[Alumno: Nombre={0} Legajo= {1} DNI= {2} Promedio= {3}]", Nombre, legajo, Dni, Promedio);
        }
    }

}
