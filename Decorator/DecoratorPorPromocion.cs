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
            string showCalification = estudiante.showResult();
            string[] splitCalification = showCalification.Split('\t');
            string decoratedCalification;
            if (Convert.ToInt32(splitCalification[1]) >= 7)
            {
                decoratedCalification = base.estudiante.showResult() + "(PROMOCION)";
            }
            else if (Convert.ToInt32(splitCalification[1]) >= 4)
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
