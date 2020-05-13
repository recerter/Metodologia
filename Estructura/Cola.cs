using Metodologia.Iterator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Metodologia.Estructura
{
    public class Cola : IColeccionable
    {
        readonly List<IComparable> elementos;
        public Cola()
        {
            elementos = new List<IComparable>();
        }

        public void Push(IComparable value)
        {
            elementos.Add(value);
        }
        public IComparable Pop()
        {
            var value = elementos[0];
            elementos.RemoveAt(0);
            return value;
        }
        public IComparable PopX(int puntero)
        {
            IComparable firstCola = this.elementos[puntero];
            return firstCola;
        }

        public IComparable Top()
        {
            return elementos[0];
        }
        public bool isEmpty()
        {
            return elementos.Count == 0;
        }

        public int Cuantos()
        {
            return elementos.Count;
        }

        public IComparable Minimo()
        {
            IComparable min = elementos[0];
            foreach (IComparable e in elementos)
            {
                if (e.SosMenor(min))
                    min = e;
            }
            return min;
        }

        public IComparable Maximo()
        {
            IComparable max = elementos[0];
            foreach (IComparable e in elementos)
            {
                if (e.SosMayor(max))
                    max = e;
            }
            return max;
        }

        public void Agregar(IComparable o)
        {
            elementos.Add(o);
        }

        public bool Contiene(IComparable o)
        {
            foreach (IComparable e in elementos)
            {
                if (e.SosIgual(o))
                    return true;
            }
            return false;
        }

        public IIteradorColeccion CrearIterador()
        {
            return new IteradorCola(this);
        }
    }
}
