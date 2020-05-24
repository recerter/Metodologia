using Metodologia.Adapter;
using Metodologia.Estructura;
using System;
using System.Collections.Generic;
using System.Text;

namespace Metodologia.Proxy
{
    class AlumnoMuyEstudiosoProxy : Student, Estructura.IComparable
    {
        private AlumnoMuyEstudioso alumnoMuyEstudiosoProxy = null;
        public AlumnoMuyEstudioso ProxyAlumnoMuyEstudioso { get { return alumnoMuyEstudiosoProxy; } private set { alumnoMuyEstudiosoProxy = value; } }
        public string Nombre { get; set; }
        public int Dni { get; set; }
        public int Legajo { get; set; }
        public int Promedio { get; set; }
        public double Calificacion { get; set; }
        public AlumnoMuyEstudiosoProxy(string nombre, int dni, int legajo, int promedio)
        {
            Nombre = nombre;
            Dni = dni;
            Legajo = legajo;
            Promedio = promedio;
            Calificacion = 1;

        }
        public bool equals(Student student)
        {
            string showCalification = student.showResult();
            string[] splitCalification = showCalification.Split('\t');
            return Calificacion.Equals(Convert.ToInt32(splitCalification[1]));
        }

        public string getName()
        {
            return Nombre;
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
            return this.Nombre + "\t" + this.Calificacion;
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
            if (ProxyAlumnoMuyEstudioso == null)
            {
                ProxyAlumnoMuyEstudioso = new AlumnoMuyEstudioso(Nombre, Dni, Legajo, Promedio);
                Console.WriteLine("Se crea el AlumnoMuyEstudioso Real");
            }
            return ProxyAlumnoMuyEstudioso.ResponderPregunta(question);
        }
    }
}
