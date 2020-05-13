using System;
using System.Collections.Generic;
using System.Text;
using Metodologia.Estructura;

namespace Metodologia.Iterator
{
    class IteradorCola : IIteradorColeccion
    {
        readonly Cola lista;
        public int actual = 0;
        public IteradorCola(Cola lista)
        {
            this.lista = lista;
        }
        public bool End()
        {
            return actual < this.lista.Cuantos() ? false : true;
        }

        public void First()
        {
            this.actual = 0;
        }

        public object Get()
        {
            return this.lista;
        }

        public object Next()
        {
            var anterior = this.lista.PopX(actual);
            actual++;
            return anterior;
        }
    }
}
