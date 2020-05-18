using System;
using System.Collections.Generic;
using System.Text;
using Metodologia.Adapter;

namespace Metodologia.Decorator
{
    public class DecoratorPorPromocion : AbsDecoratorAdicionales
    {
        public DecoratorPorPromocion(Student estudiante)
        {
            base.estudiante = estudiante;
        }
        public override string ImprimirDecorator()
        {
            string decoratedCalification;
            if (base.estudiante.getScore() >= 7)
            {
                decoratedCalification = base.estudiante.showResult() + "(PROMOCION)";
            }
            else if (base.estudiante.getScore() >= 4)
            {
                decoratedCalification = base.estudiante.showResult() + "(APROBADO)";
            }
            else
            {
                decoratedCalification = base.estudiante.showResult() + "(DESAPROBADO)";
            }

            return decoratedCalification;
        }
    }
}
