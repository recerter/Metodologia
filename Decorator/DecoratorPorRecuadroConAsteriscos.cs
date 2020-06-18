using System;
using System.Collections.Generic;
using System.Text;
using Metodologia.Adapter;
using Metodologia.Estructura;

namespace Metodologia.Decorator
{
    class DecoratorPorRecuadroConAsteriscos:AbsDecoratorAdicionales
    {
        public DecoratorPorRecuadroConAsteriscos(Alumno estudiante) : base(estudiante)
        {
        }

        public override string MostrarCalificacion()
        {
            string asteriscos = "";
            for (int i = 0; i < base.estudiante.MostrarCalificacion().Length; i++) { asteriscos += "*"; }
            asteriscos += "*****************";

            string decoratedCalification = asteriscos + "\n" +
               "*\t" + base.estudiante.MostrarCalificacion() + "\t*" +
               "\n" + asteriscos;
            return decoratedCalification;
        }
    }
}
