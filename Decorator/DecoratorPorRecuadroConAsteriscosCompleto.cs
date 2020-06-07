using System;
using System.Collections.Generic;
using System.Text;
using Metodologia.Adapter;
using Metodologia.Estructura;

namespace Metodologia.Decorator
{
    public class DecoratorPorRecuadroConAsteriscosCompleto: AbsDecoratorAdicionales
    {
        public DecoratorPorRecuadroConAsteriscosCompleto(Alumno estudiante)
        {
            base.estudiante = estudiante;
        }
        public override string ImprimirDecorator()
        {
            string asteriscos = "";
            int contador = 1;
            string decoratedPromocion;
            if (estudiante.Calificacion >= 7)
            {
                decoratedPromocion = "(PROMOCION)";
            }
            else if (estudiante.Calificacion >= 4)
            {
                decoratedPromocion = "(APROBADO)";
            }
            else
            {
                decoratedPromocion = "(DESAPROBADO)";
            }
            for (int i = 0; i < base.estudiante.MostrarCalificacion().Length; i++) { asteriscos += "*"; }
            asteriscos += "*************************************************";

            string decoratedCalification = asteriscos + "\n" +
               "*\t" +contador+")"+ estudiante.Nombre + " (" + estudiante.Legajo + ") " + "\t" + estudiante.Calificacion + "(" + LetrasPorNumeros(estudiante.Calificacion) + ")"+ decoratedPromocion + "\t*" +
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
