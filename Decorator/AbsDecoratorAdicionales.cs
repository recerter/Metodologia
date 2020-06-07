using System;
using System.Collections.Generic;
using System.Text;
using Metodologia.Estructura;
using Metodologia.Adapter;

namespace Metodologia.Decorator
{
    public abstract class AbsDecoratorAdicionales : IImprimirDecorator
    {
        public Alumno estudiante;

        public abstract string ImprimirDecorator();
    }
}
