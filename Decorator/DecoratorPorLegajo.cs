using System;
using System.Collections.Generic;
using System.Text;
using Metodologia.Adapter;

namespace Metodologia.Decorator
{
    public class DecoratorPorLegajo:AbsDecoratorAdicionales
    {
        public DecoratorPorLegajo(Student estudiante)
        {
            base.estudiante = estudiante;
        }
        public override string ImprimirDecorator()
        {
            AdapterStudent alumno = (AdapterStudent)base.estudiante;
            string showCalification = alumno.showResult();
            string[] splitCalification = showCalification.Split('\t');
            string decoratedCalification = splitCalification[0] + " (" + alumno.Adaptado.Legajo + ") " + "\t" + splitCalification[1];
            return decoratedCalification;
        }
    }
}
