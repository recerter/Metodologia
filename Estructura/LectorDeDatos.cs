using System;
using System.Collections.Generic;
using System.Text;
using Metodologia.ChainOfResponsability;

namespace Metodologia.Estructura
{
    class LectorDeDatos : Manejadores
    {
        public LectorDeDatos(Manejadores Sucesor) : base(Sucesor)
        {
        }
        public override int NumeroAleatorio(int limite)
        {
            if (Sucesor != null)
                return Sucesor.NumeroAleatorio(limite);
            return 0;
        }

        public override double NumeroDesdeArchivo(double max)
        {
            if (Sucesor != null)
                return Sucesor.NumeroDesdeArchivo(max);
            return 0;
        }

        public override int NumeroPorTeclado()
        {
            int in_number = Convert.ToInt32(Console.ReadLine());
            return in_number;
        }

        public override string StringAleatorio(int cantidad_chr)
        {
            if (Sucesor != null)
                return Sucesor.StringAleatorio(cantidad_chr);
            return "";
        }

        public override string StringDesdeArchivo(int cant)
        {
            if (Sucesor != null)
                return Sucesor.StringDesdeArchivo(cant);
            return "";
        }
        public override string StringPorTeclado()
        {
            string in_string = Console.ReadLine();
            return in_string;
        }
    }
}
