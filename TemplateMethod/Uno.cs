using Metodologia.Estructura;
using System;
using System.Collections.Generic;
using System.Text;

namespace Metodologia.TemplateMethod
{
    public class Uno : TemplateJuego
    {
        public Carta ultimacarta;
        public Pila MazoCartasDesechadas = new Pila();
        public Uno(Pila mazo, Jugador player1, Jugador player2)
        {
            cargarMazo(mazo);
            Player1 = player1;
            Player2 = player2;
            MazoCartas = mazo;
        }
        public override bool existeJugador()
        {
            return (Player1 != null | Player2 != null);
        }
        private void cargarMazo(Pila mazo)
        {
            Carta naipe;
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 12; j++)
                {
                    naipe = new Carta(j, i);
                    mazo.Push(naipe);
                }
            }
        }

        public override void Jugar()
        {
            mezclarMazo(MazoCartas);
            repartirCartasIniciales(Player1, Player2);
            ultimacarta = (Carta)MazoCartas.Pop();
            while (Player1.cartas.Count != 0 & Player2.cartas.Count != 0)
            {
                Carta naipeP1 = jugarUnaMano(MazoCartas, Player1);
                Console.WriteLine("Jugador1 Tira: " + naipeP1);
                if (Player1.cartas.Count == 0)
                    break;
                Carta naipeP2 = jugarUnaMano(MazoCartas, Player2);
                Console.WriteLine("Jugador2 Tira: " + naipeP2);
            }
             if(Player1.cartas.Count == 0)
            {
                Console.WriteLine("Ganador Jugador 1");
                Player1.Puntaje++;
            }
            if (Player2.cartas.Count == 0)
            {
                Console.WriteLine("Ganador Jugador 2");
                Player2.Puntaje++;
            }
        }

        public override Carta jugarUnaMano(Pila mazo, Jugador player)
        {
            int tiene = TieneCartaParaTirar(player);
            if (tiene >= 0)
            {
                Carta desechar = player.cartas[tiene];
                ultimacarta = desechar;
                MazoCartasDesechadas.Push(desechar);
                player.cartas.Remove(desechar);
                return desechar;
            }
            else
            {
                if(MazoCartas.Cuantos()==0)
                    MazoCartas.PushAll(MazoCartasDesechadas);
                if (MazoCartas.Cuantos() > 0)
                    {
                        player.cartas.Add((Carta)MazoCartas.Pop());
                        int tiene1 = TieneCartaParaTirar(player);
                        if (tiene1 >= 0)
                        {
                            Carta desechar = player.cartas[tiene1];
                            ultimacarta = desechar;
                            MazoCartasDesechadas.Push(desechar);
                            player.cartas.Remove(desechar);
                            return desechar;
                        }
                    }
            }
            return null;
        }

        public override void mezclarMazo(Pila mazo)
        {
            Pila arr = mazo;
            Pila arrDes = new Pila();

            Random randNum = new Random();
            while (arr.Cuantos() > 0)
            {
                int val = randNum.Next(0, arr.Cuantos());
                arrDes.Push(arr.PopX(val));
                arr.Del(val);
            }
            for (int i = 0; i < arrDes.Cuantos(); i++)
            {
                MazoCartas.Push(arrDes.PopX(i));
            }
        }

        public override void repartirCartasIniciales(Jugador player1, Jugador Player2)
        {
            for (int i = 1; i <= 8; i++)
            {
                Player1.cartas.Add((Carta)MazoCartas.Pop());
                Player2.cartas.Add((Carta)MazoCartas.Pop());
            }
        }
        private int TieneCartaParaTirar(Jugador player)
        {
            for (int c = 0; c < player.cartas.Count; c++)
            {
                if (ultimacarta.Valor == player.cartas[c].Valor)
                {
                    return c;
                }
                if (ultimacarta.Simbolo == player.cartas[c].Simbolo)
                {
                    return c;
                }
            }
            return -1;
        }
    }
}
