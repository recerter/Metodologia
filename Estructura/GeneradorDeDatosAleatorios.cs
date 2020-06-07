using Metodologia.ChainOfResponsability;
using System;
using System.Collections.Generic;
using System.Text;

namespace Metodologia.Estructura
{
    class GeneradorDeDatosAleatorios : Manejadores
    {
        private static GeneradorDeDatosAleatorios Generador { get; set; }
        private GeneradorDeDatosAleatorios(Manejadores Sucesor) : base(Sucesor)
        {
        }
        public static GeneradorDeDatosAleatorios getInstance(Manejadores Sucesor)
        {
            if (Generador == null)
                Generador = new GeneradorDeDatosAleatorios(Sucesor);
            return Generador;
        }
        public override int NumeroAleatorio(int max)
        {
            Random rnd = new Random();
            return rnd.Next(0, max);
        }

        public override double NumeroDesdeArchivo(double max)
        {
            if (Sucesor != null)
                return Sucesor.NumeroDesdeArchivo(max);
            return 0;
        }

        public override int NumeroPorTeclado()
        {
            if (Sucesor != null)
                return Sucesor.NumeroPorTeclado();
            return 0;
        }

        public override string StringAleatorio(int cant)
        {
            Random obj = new Random();
            string posibles = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int longitud = posibles.Length;
            char letra;
            int longitudnuevacadena = cant;
            string nuevacadena = "";
            for (int i = 0; i < longitudnuevacadena; i++)
            {
                letra = posibles[obj.Next(longitud)];
                nuevacadena += letra.ToString();
            }
            return nuevacadena;
        }

        public override string StringDesdeArchivo(int cant)
        {
            if (Sucesor != null)
                return Sucesor.StringDesdeArchivo(cant);
            return "";
        }

        public override string StringPorTeclado()
        {
            if (Sucesor != null)
                return Sucesor.StringPorTeclado();
            return "";
        }
    }
}
