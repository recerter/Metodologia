using System;
using System.Collections.Generic;
using System.Text;

namespace Metodologia.Esructura
{
    class ColeccionMultiple : IColeccionable
    {
        readonly Pila pila;
        readonly Cola cola;

        public ColeccionMultiple(Pila pila, Cola cola)
        {
            this.pila = pila;
            this.cola = cola;
        }

        public void Agregar(IComparable o)
        {
            throw new NotImplementedException();
        }

        public bool Contiene(IComparable o)
        {
            if (pila.Contiene(o) || cola.Contiene(o))
                return true;
            return false;
        }

        public int Cuantos()
        {
            return pila.Cuantos() + cola.Cuantos();
        }

        public IComparable Maximo()
        {
            IComparable maxcola;
            IComparable maxpila;
            maxcola = cola.Maximo();
            maxpila = pila.Maximo();
            if (maxcola.sosMayor(maxpila))
            {
                return maxcola;
            }
            else
            {
                return maxpila;
            }
        }

        public IComparable Minimo()
        {
            IComparable mincola;
            IComparable minpila;
            mincola = cola.Minimo();
            minpila = pila.Minimo();
            if (mincola.sosMenor(minpila))
            {
                return mincola;
            }
            else
            {
                return minpila;
            }

        }
    }
}
