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

        public bool SosIgual(IComparable o)
        {
            Alumno n = o as Alumno;
            return Legajo == n.Legajo;
        }
        
        public bool SosMayor(IComparable o)
        {
            Alumno n = o as Alumno;
            return Legajo > n.Legajo;
        }
        

        public bool SosMenor(IComparable o)
        {
            Alumno n = o as Alumno;
            return Legajo < n.Legajo;
        }
       
        public override string ToString()
        {
            return string.Format("[Alumno: Nombre={0} Legajo= {1} DNI= {2}]", Nombre, legajo, Dni);
        }
    }
}
