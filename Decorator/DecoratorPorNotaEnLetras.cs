using System;
using System.Collections.Generic;
using System.Text;
using Metodologia.Adapter;

namespace Metodologia.Decorator
{
    public class DecoratorPorNotaEnLetras:AbsDecoratorAdicionales
    {
        public DecoratorPorNotaEnLetras(Student estudiante)
        {
            base.estudiante = estudiante;
        }
        public override string ImprimirDecorator()
        {
            string showCalification = estudiante.showResult();
            string[] splitCalification = showCalification.Split('\t');
            
            string decoratedCalification = base.estudiante.showResult() + "(" + LetrasPorNumeros(Convert.ToInt32(splitCalification[1])) + ")";
            return decoratedCalification;
        }

        public string LetrasPorNumeros(int aConvertir)
        {
            string[] numerosConvertidos = { "CERO", "UNO", "DOS", "TRES", "CUATRO", "CINCO", "SEIS", "SIETE", "OCHO", "NUEVE", "DIEZ" };
            return numerosConvertidos[aConvertir];
        }
    }
}
