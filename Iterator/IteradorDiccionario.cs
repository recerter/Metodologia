using System;
using System.Collections.Generic;
using System.Text;
using Metodologia.Estructura;

namespace Metodologia.Iterator
{
    class IteradorDiccionario : IIteradorColeccion
    {
        readonly Diccionario lista;
        public int actual = 0;
        public IteradorDiccionario(Diccionario lista)
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
            return lista;
        }

        public object Next()
        {
            var anterior = this.lista.ValorDe(actual);
            actual++;
            return anterior;
        }
    }
}
