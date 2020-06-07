using System;
using System.Collections.Generic;
using System.Text;
using Metodologia.Adapter;
using Metodologia.Estructura;

namespace Metodologia.Decorator
{
    public class DecoratorPorLegajo:AbsDecoratorAdicionales
    {
        public DecoratorPorLegajo(Alumno estudiante)
        {
            base.estudiante = estudiante;
        }
        public override string ImprimirDecorator()
        {
            string decoratedCalification = estudiante.Nombre + " (" + estudiante.Legajo + ") " + "\t" + estudiante.Calificacion;
            return decoratedCalification;
        }
    }
}
