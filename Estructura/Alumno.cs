using Metodologia.Strategy;
using System;
using System.Collections.Generic;
using System.Text;
using Metodologia.Decorator;
using Metodologia.Adapter;

namespace Metodologia.Estructura
{
    public class Alumno:Persona, IComparable,IImprimirDecorator
    {
        private int legajo;
        private int promedio;
        private int calificacion;

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
        public int Calificacion
        {
            get
            {
                return this.calificacion;
            }
            set{
                this.calificacion = value;
            }
        }

        public string MostrarCalificacion()
        {
            return Calificacion.ToString();
        }

        public int ResponderPregunta(int pregunta)
        {
            return new Random().Next(1, 3);
        }

        public bool SosIgual(Alumno comparable)
        {
            return Estrategia.SosIgual(this, comparable);
        }

        public bool SosMenor(Alumno comparable)
        {
            return Estrategia.SosMenor(this, comparable);
        }

        public bool SosMayor(Alumno comparable)
        {
            return Estrategia.SosMayor(this, comparable);
        }

        public override string ToString()
        {
            return string.Format("[Alumno: Nombre={0} Legajo= {1} DNI= {2} Promedio= {3}]", Nombre, legajo, Dni, Promedio);
        }

        public string ImprimirDecorator()
        {
            return new DecoratorPorRecuadroConAsteriscosCompleto(this).ImprimirDecorator();
        }

    }

}
