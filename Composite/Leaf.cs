using Metodologia.Estructura;
using System;
using System.Collections.Generic;
using System.Text;

namespace Metodologia.Composite
{
    public class Leaf : Composite
    {
        public Alumno AlumnHoja;
        public Leaf(string nombre, int dni, int legajo, int promedio, int calificacion) : base(nombre, dni, legajo, promedio)
        {
            AlumnHoja = new Alumno(nombre, dni, legajo, calificacion);
            AlumnHoja.Calificacion = calificacion;
        }

        public override void GetNombre()
        {
            Console.Write(AlumnHoja.Nombre+ " ");
        }

        public new string ImprimirDecorator()
        {
            return AlumnHoja.ImprimirDecorator();
        }

        public override string MostrarCalificacion()
        {
            return AlumnHoja.MostrarCalificacion();
        }

        public override int Responder(int pregunta)
        {
            return AlumnHoja.ResponderPregunta(pregunta);
        }

        public new int ResponderPregunta(int pregunta)
        {
            return AlumnHoja.ResponderPregunta(pregunta);
        }

        public override void SetCalificacion(int inCalificacion)
        {
            AlumnHoja.Calificacion = inCalificacion;
        }

        public override bool SosIgual(Alumno c)
        {
            return AlumnHoja.SosIgual(c);
        }

        public override bool SosMayor(Alumno c)
        {
            return AlumnHoja.SosMayor(c);
        }

        public override bool SosMenor(Alumno c)
        {
            return AlumnHoja.SosMenor(c);
        }
    }
}
