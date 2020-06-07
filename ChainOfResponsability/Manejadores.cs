using System;
using System.Collections.Generic;
using System.Text;
using Metodologia.Estructura;

namespace Metodologia.ChainOfResponsability
{
    public abstract class Manejadores
    {
        public Manejadores Sucesor { get; set; }

        public Manejadores(Manejadores Sucesor)
        {
            this.Sucesor = Sucesor;
        }

        public abstract double NumeroDesdeArchivo(double max);
        public abstract string StringDesdeArchivo(int cant);
        public abstract int NumeroAleatorio(int limite);
        public abstract string StringAleatorio(int cantidad_chr);
        public abstract int NumeroPorTeclado();
        public abstract string StringPorTeclado();
    }
}
