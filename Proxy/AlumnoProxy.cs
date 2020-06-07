using Metodologia.Adapter;
using Metodologia.Estructura;
using System;
using System.Collections.Generic;
using System.Text;

namespace Metodologia.Proxy
{
    public class AlumnoProxy : Alumno
    {
        private Alumno proxyAlumno = null;
        private string nombre;
        private int dni;
        private int legajo;
        private int promedio;
        public new int Calificacion;

        public AlumnoProxy(string nombre, int dni, int legajo, int promedio): base(nombre, dni,legajo, promedio)
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

        public int ResponderPregunta(int question)
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
