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
        public Jugador Jugar()
        {
            mezclarMazo(MazoCartas);
            if (Player1.cartas.Count.Equals(0) || Player2.cartas.Count.Equals(0))
                repartirCartasIniciales(Player1, Player2);
            Carta naipeP1 = jugarUnaMano(MazoCartas, Player1);
            Carta naipeP2 = jugarUnaMano(MazoCartas, Player2);
            Console.WriteLine("Jugador 1({0}):\t Carta: {1} {2}", Player1.Nombre, naipeP1.Valor, naipeP1.Simbolo);
            Console.WriteLine("Jugador 2({0}):\t Carta: {1} {2}", Player2.Nombre, naipeP2.Valor, naipeP2.Simbolo);
            existeJugador();
            if (naipeP1.SosMayor(naipeP2))
            {
                Player1.Puntaje += 2;
                return Player1;
            }
            else
            {
                Player2.Puntaje += 2;
                return Player2;
            }

        }

        public abstract void mezclarMazo(Pila mazo);
        public abstract void repartirCartasIniciales(Jugador player1, Jugador Player2);
        public abstract Carta jugarUnaMano(Pila mazo, Jugador player);
        public abstract bool existeJugador();
    }
}
