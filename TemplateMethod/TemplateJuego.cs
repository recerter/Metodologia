using Metodologia.Estructura;
using System;
using System.Collections.Generic;
using System.Text;

namespace Metodologia.TemplateMethod
{
    public abstract class TemplateJuego
    {
        public Jugador Player1 { get; set; }
        public Jugador Player2 { get; set; }
        public Pila MazoCartas { get; set; }
        public abstract void Jugar();
        public abstract void mezclarMazo(Pila mazo);
        public abstract void repartirCartasIniciales(Jugador player1, Jugador Player2);
        public abstract Carta jugarUnaMano(Pila mazo, Jugador player);
        public abstract bool existeJugador();
    }
}
