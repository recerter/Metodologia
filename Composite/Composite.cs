using Metodologia.Estructura;
using System;
using System.Collections.Generic;
using System.Text;

namespace Metodologia.Composite
{
    public abstract class Composite: Alumno
    {
        public string nombre;
        public int dni;
        public int legajo;
        public int promedio;
        public int calificacion;
        public Composite(string nombre, int dni, int legajo, int promedio):base(nombre, dni, legajo, promedio)
        {
            this.nombre = nombre;
            this.dni = dni;
            this.legajo = legajo;
            this.promedio = promedio;
        }
        public abstract void GetNombre();
        public abstract int Responder(int pregunta);
        public abstract void SetCalificacion(int Calificacion);
        public abstract string MostrarCalificacion();
        public new abstract bool SosIgual(Alumno comparable);
        public new abstract bool SosMayor(Alumno comparable);
        public new abstract bool SosMenor(Alumno comparable);
    }
}
