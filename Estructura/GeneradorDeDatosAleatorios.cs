using System;
using System.Collections.Generic;
using System.Text;

namespace Metodologia.Estructura
{
    class GeneradorDeDatosAleatorios
    {
        public int NumeroAleatorio(int max)
        {
            Random rnd = new Random();
            return rnd.Next(0, max);
        }

        public string StringAleatorio(int cant)
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
    }
}
