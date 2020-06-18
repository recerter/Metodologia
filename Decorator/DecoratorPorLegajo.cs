using System;
using System.Collections.Generic;
using System.Text;
using Metodologia.Adapter;
using Metodologia.Estructura;

namespace Metodologia.Decorator
{
    public class DecoratorPorLegajo:AbsDecoratorAdicionales
    {
        public DecoratorPorLegajo(Alumno estudiante) : base(estudiante)
        {
        }
        public override string MostrarCalificacion()
        {
            return estudiante.MostrarCalificacion() + "(s"+Legajo+"s)";
        }
    }
}
