using System;
using System.Collections.Generic;
using System.Text;
using Metodologia.Adapter;

namespace Metodologia.Decorator
{
    public class DecoratorPorRecuadroConAsteriscosCompleto: AbsDecoratorAdicionales
    {
        public DecoratorPorRecuadroConAsteriscosCompleto(Student estudiante)
        {
            base.estudiante = estudiante;
        }
        public override string ImprimirDecorator()
        {
            AdapterStudent alumno = (AdapterStudent)base.estudiante;
            string showCalification = alumno.showResult();
            string[] splitCalification = showCalification.Split('\t');
            string asteriscos = "";
            int contador = 1;
            string decoratedPromocion;
            if (alumno.getScore() >= 7)
            {
                decoratedPromocion = "(PROMOCION)";
            }
            else if (alumno.getScore() >= 4)
            {
                decoratedPromocion = "(APROBADO)";
            }
            else
            {
                decoratedPromocion = "(DESAPROBADO)";
            }
            for (int i = 0; i < base.estudiante.showResult().Length; i++) { asteriscos += "*"; }
            asteriscos += "*************************************************";

            string decoratedCalification = asteriscos + "\n" +
               "*\t" +contador+")"+ splitCalification[0] + " (" + alumno.Adaptado.Legajo + ") " + "\t" + splitCalification[1] + "(" + LetrasPorNumeros(alumno.getScore()) + ")"+ decoratedPromocion + "\t*" +
               "\n" + asteriscos;
            contador++;
            return decoratedCalification;
        }
        public string LetrasPorNumeros(int aConvertir)
        {
            string[] numerosConvertidos = { "CERO", "UNO", "DOS", "TRES", "CUATRO", "CINCO", "SEIS", "SIETE", "OCHO", "NUEVE", "DIEZ" };
            return numerosConvertidos[aConvertir];
        }
    }
}
