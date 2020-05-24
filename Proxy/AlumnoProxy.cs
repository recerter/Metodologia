using Metodologia.Adapter;
using Metodologia.Estructura;
using System;
using System.Collections.Generic;
using System.Text;

namespace Metodologia.Proxy
{
    public class AlumnoProxy : Student, Estructura.IComparable
    {
        private Alumno proxyAlumno = null;
        private string nombre;
        private int dni;
        private int legajo;
        private int promedio;
        public double Calificacion;

        public AlumnoProxy(string nombre, int dni, int legajo, int promedio)
        {
            this.nombre = nombre;
            this.dni = dni;
            this.legajo = legajo;
            this.promedio = promedio;
            Calificacion = 1;
        }
        public Alumno ProxyAlumno
        {
            get
            {
                return proxyAlumno;
            }
            set
            {
                this.proxyAlumno = value;
            }
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
        public bool equals(Student student)
        {
            string showCalification = student.showResult();
            string[] splitCalification = showCalification.Split('\t');
            return Calificacion.Equals(Convert.ToInt32(splitCalification[1]));
        }

        public string getName()
        {
            return nombre;
        }

        public bool greaterThan(Student student)
        {
            string showCalification = student.showResult();
            string[] splitCalification = showCalification.Split('\t');
            return Calificacion > Convert.ToInt32(splitCalification[1]) ? true : false;
        }

        public bool lessThan(Student student)
        {
            string showCalification = student.showResult();
            string[] splitCalification = showCalification.Split('\t');
            return Calificacion < Convert.ToInt32(splitCalification[1]) ? true : false;
        }

        public void setScore(int score)
        {
            Calificacion = score;
        }

        public string showResult()
        {
            return this.nombre + "\t" + this.Calificacion;
        }

        public bool SosIgual(Estructura.IComparable o)
        {
            throw new NotImplementedException();
        }

        public bool SosMayor(Estructura.IComparable o)
        {
            throw new NotImplementedException();
        }

        public bool SosMenor(Estructura.IComparable o)
        {
            throw new NotImplementedException();
        }

        public int yourAnswerIs(int question)
        {
            if (ProxyAlumno == null)
            {
                ProxyAlumno = new Alumno(nombre, dni, Legajo, Promedio);
                Console.WriteLine("Se crea el Alumno Real");
            }
            return ProxyAlumno.ResponderPregunta(question);
        }
    }
}
