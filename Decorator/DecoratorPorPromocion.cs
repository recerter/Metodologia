using System;
using System.Collections.Generic;
using System.Text;
using Metodologia.Adapter;
using Metodologia.Estructura;

namespace Metodologia.Decorator
{
    public class DecoratorPorPromocion : AbsDecoratorAdicionales
    {
        public DecoratorPorPromocion(Alumno estudiante)
        {
            base.estudiante = estudiante;
        }
        public override string ImprimirDecorator()
        {
            string decoratedCalification;
            if (estudiante.Calificacion >= 7)
            {
                decoratedCalification = base.estudiante.MostrarCalificacion() + "(PROMOCION)";
            }
            else if (estudiante.Calificacion >= 4)
            {
                decoratedCalification = base.estudiante.MostrarCalificacion() + "(APROBADO)";
            }
            else
            {
                decoratedCalification = base.estudiante.MostrarCalificacion() + "(DESAPROBADO)";
            }

            return decoratedCalification;
        }
    }
}
