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
            string showCalification = student.showResult();
            string[] splitCalification = showCalification.Split('\t');
            return Adaptado.Calificacion.Equals(Convert.ToInt32(splitCalification[1]));
        }

        public string getName()
        {
            return Adaptado.Nombre;
        }
        public bool greaterThan(Student student)
        {
            string showCalification = student.showResult();
            string[] splitCalification = showCalification.Split('\t');
            return Adaptado.Calificacion > Convert.ToInt32(splitCalification[1]) ? true : false;
        }

        public bool lessThan(Student student)
        {
            string showCalification = student.showResult();
            string[] splitCalification = showCalification.Split('\t');
            return Adaptado.Calificacion < Convert.ToInt32(splitCalification[1]) ? true : false;
        }

        public void setScore(int score)
        {
            Adaptado.Calificacion = score;
        }

        public string showResult()
        {
            return Adaptado.MostrarCalificacion();
        }

        public int yourAnswerIs(int question)
        {
            return Adaptado.ResponderPregunta(question);
        }
    }
}
