using System;
using System.Collections.Generic;
using System.Text;
using Metodologia.Adapter;
using Metodologia.Estructura;

namespace Metodologia.Decorator
{
    public class DecoratorPorNotaEnLetras:AbsDecoratorAdicionales
    {
        public DecoratorPorNotaEnLetras(Alumno estudiante) : base(estudiante)
        {
        }
        public override string MostrarCalificacion()
        {
            string decoratedCalification = base.estudiante.MostrarCalificacion() + "(" + LetrasPorNumeros(estudiante.Calificacion) + ")";
            return decoratedCalification;
        }

        public string LetrasPorNumeros(int aConvertir)
        {
            string[] numerosConvertidos = { "CERO", "UNO", "DOS", "TRES", "CUATRO", "CINCO", "SEIS", "SIETE", "OCHO", "NUEVE", "DIEZ" };
            return numerosConvertidos[aConvertir];
        }
    }
}
