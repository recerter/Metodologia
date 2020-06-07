using System;
using System.Collections.Generic;
using System.Text;
using Metodologia.Composite;
using Metodologia.Estructura;

namespace Metodologia.Adapter
{
    public class AdapterComposite: Composite.Composite
    {
        Composite.Composite Adaptado;
        public AdapterComposite(string nombre, int dni, int legajo, int calificacion) : base(nombre, dni, legajo, calificacion)
        {
            Adaptado = new Leaf(nombre, dni, legajo, legajo, calificacion);
        }
        public override void GetNombre()
        {
            Console.Write(Adaptado.nombre + " ");
        }

        public override string MostrarCalificacion()
        {
            return Adaptado.MostrarCalificacion();
        }

        public override int Responder(int pregunta)
        {
            return Adaptado.Responder(pregunta);
        }

        public override void SetCalificacion(int inCalificacion)
        {
            Adaptado.SetCalificacion(inCalificacion);
        }

        public override bool SosIgual(Alumno comparable)
        {
            return Adaptado.SosIgual(comparable);
        }

        public override bool SosMayor(Alumno comparable)
        {
            return Adaptado.SosMayor(comparable);
        }

        public override bool SosMenor(Alumno comparable)
        {
            return Adaptado.SosMenor(comparable);
        }
    }
}
