using System;
using System.Collections.Generic;
using System.Text;
using Metodologia.Estructura;
using Metodologia.Adapter;

namespace Metodologia.Decorator
{
    public abstract class AbsDecoratorAdicionales : Alumno
    {
        public Alumno estudiante;

        public AbsDecoratorAdicionales(Alumno estudiante)
        {
            this.estudiante = estudiante;
        }
       
        public override int ResponderPregunta(int pregunta)
        {
                return estudiante.ResponderPregunta(pregunta);
        }
        public override string MostrarCalificacion()
        {
            if (estudiante != null)
                return estudiante.MostrarCalificacion();
            return "";
        }
        override public int Legajo
        {
            get
            {
                return this.Legajo;
            }
            set
            {
                this.Legajo = value;
            }
        }

    }
}
