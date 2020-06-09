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

        public Jugador(string nombre, int dni) : base(nombre, dni)
        {
            this.Puntaje = 0;
            cartas = new List<Carta>();
        }
    }
}
