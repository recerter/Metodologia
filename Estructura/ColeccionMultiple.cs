using System;
using System.Collections.Generic;
using System.Text;

namespace Metodologia.Estructura
{
    public class ColeccionMultiple : IColeccionable
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

        public object Maximo()
        {
            IComparable maxcola;
            IComparable maxpila;
            maxcola = (IComparable)cola.Maximo();
            maxpila = (IComparable)pila.Maximo();
            if (maxcola.SosMayor(maxpila))
            {
                return maxcola;
            }
            else
            {
                return maxpila;
            }
        }

        public object Minimo()
        {
            IComparable mincola;
            IComparable minpila;
            mincola = (IComparable)cola.Minimo();
            minpila = (IComparable)pila.Minimo();
            if (mincola.SosMenor(minpila))
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
