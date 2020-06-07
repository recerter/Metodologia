using Metodologia.Estructura;
using System;
using System.Collections.Generic;
using System.Text;
using Metodologia.Decorator;

namespace Metodologia.Adapter
{
    class AdapterStudent : Student
    {
        private Alumno adaptado;

        public AdapterStudent(Alumno alumno)
        {
            this.adaptado = alumno;
        }

        public Alumno Adaptado
        {
            get
            {
                return adaptado;
            }
            set
            {
                adaptado = value;
            }
        }
        public bool equals(Student student)
        {
            return Adaptado.Calificacion.Equals(Convert.ToInt32(Adaptado.MostrarCalificacion()));
        }

        public string getName()
        {
            return Adaptado.Nombre;
        }
        public bool greaterThan(Student student)
        {
            return adaptado.SosMayor(((AdapterStudent)(student)).adaptado);
        }

        public bool lessThan(Student student)
        {
            return adaptado.SosMenor(((AdapterStudent)(student)).adaptado);
        }

        public void setScore(int score)
        {
            Adaptado.Calificacion = score;
        }

        public string showResult()
        {
            return Adaptado.ImprimirDecorator();
        }

        public int yourAnswerIs(int question)
        {
            return Adaptado.ResponderPregunta(question);
        }
    }
}
