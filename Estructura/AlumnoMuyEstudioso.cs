using System;
using System.Collections.Generic;
using System.Text;
using Metodologia.Strategy;

namespace Metodologia.Estructura
{
    public class AlumnoMuyEstudioso:Alumno
    {
        public AlumnoMuyEstudioso(string nombre, int dni, int legajo, int promedio) : base(nombre, dni, legajo, promedio)
        {
            base.Nombre = nombre;
            base.Dni = dni;
            base.Legajo = legajo;
            base.Promedio = promedio;
            base.Estrategia = new EstrategiaCompararNombre();
        }

        public new int ResponderPregunta(int pregunta)
        {
            return pregunta % 3;
        }
    }
}
