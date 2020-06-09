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
            return (Player1 != null | Player2 != null);
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
                    naipe.Prioridad = Prioridad(numeronaipe, i);

                    mazo.Push(naipe);
                }
            }
        }

        public override Carta jugarUnaMano(Pila mazo, Jugador player)
        {
            Carta desechar = mayorvalor(player);
            player.cartas.Remove(desechar);
            return desechar;
        }

        public override void Jugar()
        {
            Console.WriteLine("Carta de Ambos Jugadores");
                mezclarMazo(MazoCartas);
                repartirCartasIniciales(Player1, Player2);
            int puntoj1 = 0, puntoj2 = 0;
            Console.WriteLine("Jugador 1({0}):\t Carta: {1} {2}, {3} {4}, {5} {6}", Player1.Nombre, Player1.cartas[0].Valor, Player1.cartas[0].Simbolo, Player1.cartas[1].Valor, Player1.cartas[1].Simbolo, Player1.cartas[2].Valor, Player1.cartas[2].Simbolo);
            Console.WriteLine("Jugador 2({0}):\t Carta: {1} {2}, {3} {4}, {5} {6}", Player2.Nombre, Player2.cartas[0].Valor, Player2.cartas[0].Simbolo, Player2.cartas[1].Valor, Player2.cartas[1].Simbolo, Player2.cartas[2].Valor, Player2.cartas[2].Simbolo);
            for (int g = 1; g <= 3; g++)
            {
                Console.WriteLine("\tSe Juega "+g+"ra Mano");
                Carta naipeP1 = jugarUnaMano(MazoCartas, Player1);
                Carta naipeP2 = jugarUnaMano(MazoCartas, Player2);
                Console.WriteLine("Jugador 1({0}):\t Carta: {1} {2}", Player1.Nombre, naipeP1.Valor, naipeP1.Simbolo);
                Console.WriteLine("Jugador 2({0}):\t Carta: {1} {2}", Player2.Nombre, naipeP2.Valor, naipeP2.Simbolo);
                if (g == 1 & naipeP1.Prioridad == naipeP2.Prioridad)
                    g++;
                if (naipeP1.Prioridad < naipeP2.Prioridad)
                {
                    Console.WriteLine("*************Gana la Mano Jugador1**************");
                    puntoj1++;
                    if (puntoj1 == 2)
                        break;
                }
                if (naipeP1.Prioridad > naipeP2.Prioridad)
                {
                    Console.WriteLine("*************Gana la Mano Jugador2**************");
                    puntoj2++;
                    if (puntoj2 == 2)
                        break;
                }
            }
            if (puntoj1>=2)
            {
                Console.WriteLine("*************Gana la Partida Jugador1**************");
                Player1.Puntaje++;
            }
            if (puntoj2>=2)
            {
                Console.WriteLine("*************Gana la Partida Jugador2**************");
                Player2.Puntaje++;
            }
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
            for (int i = 1; i <= 3; i++)
            {
                Player1.cartas.Add((Carta)MazoCartas.Pop());
                Player2.cartas.Add((Carta)MazoCartas.Pop());
            }
        }
        private Carta mayorvalor(Jugador player)
        {
            Carta max = player.cartas[0];
                for(int c = 0; c< player.cartas.Count; c++)
            {
                if (max.Prioridad > player.cartas[c].Prioridad)
                {
                    max = player.cartas[c];
                }
                
            }
            return max;
        }
        private int Prioridad(int n, int s)
        {
            //n = numero de naipe, s = tipo
            if (n == 1 & s == 1)
                return 1;
            if (n == 1 & s == 2)
                return 2;
            if (n == 7 & s == 1)
                return 3;
            if (n == 7 & s == 3)
                return 4;
            if (n == 3 & s == 1)
                return 5;
            if (n == 3 & s == 2)
                return 5;
            if (n == 3 & s == 3)
                return 5;
            if (n == 3 & s == 4)
                return 5;
            if (n == 2 & s == 1)
                return 6;
            if (n == 2 & s == 2)
                return 6;
            if (n == 2 & s == 3)
                return 6;
            if (n == 2 & s == 4)
                return 6;
            if (n == 1 & s == 3)
                return 7;
            if (n == 1 & s == 4)
                return 8;
            if (n == 12 & s == 1)
                return 9;
            if (n == 12 & s == 2)
                return 9;
            if (n == 12 & s == 3)
                return 9;
            if (n == 12 & s == 4)
                return 9;
            if (n == 11 & s == 1)
                return 10;
            if (n == 11 & s == 2)
                return 10;
            if (n == 11 & s == 3)
                return 10;
            if (n == 11 & s == 4)
                return 10;
            if (n == 10 & s == 1)
                return 11;
            if (n == 10 & s == 2)
                return 11;
            if (n == 10 & s == 3)
                return 11;
            if (n == 10 & s == 4)
                return 11;
            if (n == 7 & s == 2)
                return 12;
            if (n == 7 & s == 4)
                return 12;
            if (n == 6 & s == 1)
                return 13;
            if (n == 6 & s == 2)
                return 13;
            if (n == 6 & s == 3)
                return 13;
            if (n == 6 & s == 4)
                return 13;
            if (n == 5 & s == 1)
                return 14;
            if (n == 5 & s == 2)
                return 14;
            if (n == 5 & s == 3)
                return 14;
            if (n == 5 & s == 4)
                return 14;
            if (n == 4 & s == 1)
                return 15;
            if (n == 4 & s == 2)
                return 15;
            if (n == 4 & s == 3)
                return 15;
            if (n == 4 & s == 4)
                return 15;
            return -1;
        }
    }
}
