using Metodologia.Adapter;
using Metodologia.Estructura;
using System;
using System.Collections.Generic;
using System.Text;

namespace Metodologia.Proxy
{
    class AlumnoMuyEstudiosoProxy : AlumnoMuyEstudioso
    {
        private AlumnoMuyEstudioso alumnoMuyEstudiosoProxy = null;
        public AlumnoMuyEstudioso ProxyAlumnoMuyEstudioso { get { return alumnoMuyEstudiosoProxy; } private set { alumnoMuyEstudiosoProxy = value; } }
        public AlumnoMuyEstudiosoProxy(string nombre, int dni, int legajo, int promedio):base (nombre, dni,legajo, promedio)
        {
            Nombre = nombre;
            Dni = dni;
            Legajo = legajo;
            Promedio = promedio;
            Calificacion = 1;

        }
        public int ResponderPregunta(int question)
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
