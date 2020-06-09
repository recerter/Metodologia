using Metodologia.Estructura;
using Metodologia.FactoryMethod;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Metodologia.TemplateMethod
{
    public class Main
    {
        public static void Run()
        {
            Pila nuevoMazo = new Pila();
            Jugador jugador1 = (Jugador)new FabricaDeJugadores().CrearAleatorio();
            Jugador jugador2 = (Jugador)new FabricaDeJugadores().CrearAleatorio();
            TemplateJuego nuevoJuego;
            Console.WriteLine("Elija El Juego");
            Console.WriteLine("1) Truco");
            Console.WriteLine("2) Uno");
            int opcion = Convert.ToInt32(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("1)Jugar Una Mano");
                    Console.WriteLine("2)Jugar Una Partida");
                    int opcion1 = Convert.ToInt32(Console.ReadLine());
                    switch (opcion1)
                    {
                        case 1:
                            nuevoJuego = new Truco(nuevoMazo, jugador1, jugador2);
                            nuevoJuego.Jugar();
                            break;
                        case 2:
                            jugador1.Puntaje = 0;
                            jugador2.Puntaje = 0;
                            while ((jugador1.Puntaje < 15) & (jugador2.Puntaje < 15))
                            {
                                nuevoJuego = new Truco(nuevoMazo, jugador1, jugador2);
                                nuevoJuego.Jugar();
                            }
                            if (jugador1.Puntaje == 15)
                            {
                                Console.WriteLine("Gana Jugador1");
                                Console.WriteLine("Resultados: ");
                                Console.WriteLine("Jugador1: " + jugador1.Puntaje);
                                Console.WriteLine("Jugador2: " + jugador2.Puntaje);
                            }
                            else
                            {
                                Console.WriteLine("Gana Jugador2");
                                Console.WriteLine("Resultados: ");
                                Console.WriteLine("Jugador1: " + jugador1.Puntaje);
                                Console.WriteLine("Jugador2: " + jugador2.Puntaje);
                            }
                            break;
                        default:
                            break;
                    }
                    break;
                case 2:
                    Console.WriteLine("1)Jugar Una Mano");
                    Console.WriteLine("2)Jugar Una Partida");
                    int opcion2 = Convert.ToInt32(Console.ReadLine());
                    switch (opcion2)
                    {
                        case 1:
                            nuevoJuego = new Uno(nuevoMazo, jugador1, jugador2);
                            nuevoJuego.Jugar();
                            break;
                        case 2:
                            jugador1.Puntaje = 0;
                            jugador2.Puntaje = 0;
                            while ((jugador1.Puntaje < 10) & (jugador2.Puntaje < 10))
                            {
                                nuevoJuego = new Uno(nuevoMazo, jugador1, jugador2);
                                nuevoJuego.Jugar();
                            }
                            if (jugador1.Puntaje == 10)
                            {
                                Console.WriteLine("Gana Jugador1");
                                Console.WriteLine("Resultados: ");
                                Console.WriteLine("Jugador1: " + jugador1.Puntaje);
                                Console.WriteLine("Jugador2: " + jugador2.Puntaje);
                            }
                            else
                            {
                                Console.WriteLine("Gana Jugador2");
                                Console.WriteLine("Resultados: ");
                                Console.WriteLine("Jugador1: " + jugador1.Puntaje);
                                Console.WriteLine("Jugador2: " + jugador2.Puntaje);
                            }
                            break;
                    }
                    break;
            }
            
        }
       
    }
}

