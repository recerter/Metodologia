using Metodologia.Estructura;
using System;
using System.Collections.Generic;
using System.Text;
using Metodologia.Iterator;

namespace Metodologia.TemplateMethod
{
    public class Truco:TemplateJuego
    {
        public Truco(Pila mazo, Jugador player1, Jugador player2)
        {
            cargarMazo(mazo);
            Player1 = player1;
            Player2 = player2;
            MazoCartas = mazo;
        }

        public override bool existeJugador()
        {
            return (Player1 != null | Player2 != null) ? true : false;
        }
        private void cargarMazo(Pila mazo)
        {
            Carta naipe;
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    int numeronaipe = j;
                    if (j == 8)
                        numeronaipe = 10;
                    if (j == 9)
                        numeronaipe = 11;
                    if (j == 10)
                        numeronaipe = 12;
                    naipe = new Carta(numeronaipe, i);
                    mazo.Push(naipe);
                }
            }
        }

        public override Carta jugarUnaMano(Pila mazo, Jugador player)
        {
            throw new NotImplementedException();
        }

        public override void mezclarMazo(Pila mazo)
        {
            List<Carta> mazoMezclado = new List<Carta>();
            IIteradorColeccion iter = mazo.CrearIterador();
            while (!iter.End())
            {
                mazoMezclado.Add((Carta)iter.Next());
            }
            for (int j = 0; j < 5; j++)
            {
                int numero = mazoMezclado.Count;
                numero = numero - (j * 10);
                for (int i = 0; i < 5; i++)
                {
                    numero = numero / 2;
                    if (numero - 1 > 0)
                    {
                        Carta anterior = mazoMezclado[numero - 1];
                        mazoMezclado[numero - 1] = mazoMezclado[(numero * 2) - 1];
                        mazoMezclado[(numero * 2) - 1] = anterior;
                    }
                }
            }
            mazo = new Pila();
            for (int i = 0; i < mazoMezclado.Count; i++)
            {
                mazo.Push(mazoMezclado[i]);
            }
        }

        public override void repartirCartasIniciales(Jugador player1, Jugador Player2)
        {
            for (int i = 1; i <= 3; i++)
            {
                Player1.cartas.Add((Carta)MazoCartas.Pop());
                Player2.cartas.Add((Carta)MazoCartas.Pop());
            }
        }
    }
}
