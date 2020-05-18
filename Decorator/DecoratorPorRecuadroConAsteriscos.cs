using System;
using System.Collections.Generic;
using System.Text;
using Metodologia.Adapter;

namespace Metodologia.Decorator
{
    class DecoratorPorRecuadroConAsteriscos:AbsDecoratorAdicionales
    {
        public DecoratorPorRecuadroConAsteriscos(Student estudiante)
        {
            base.estudiante = estudiante;
        }

        public override string ImprimirDecorator()
        {
            string asteriscos = "";
            for (int i = 0; i < base.estudiante.showResult().Length; i++) { asteriscos += "*"; }
            asteriscos += "*****************";

            string decoratedCalification = asteriscos + "\n" +
               "*\t" + base.estudiante.showResult() + "\t*" +
               "\n" + asteriscos;
            return decoratedCalification;
        }
    }
}
