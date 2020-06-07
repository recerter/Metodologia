using Metodologia.Estructura;
using System;
using System.Collections.Generic;
using System.Text;

namespace Metodologia.TemplateMethod
{
    public class Jugador:Persona
    {
        public List<Carta> cartas { get; set; }
        public int Puntaje { get; set; }

        public Jugador()
        {
            cartas = new List<Carta>();
        }
    }
}
