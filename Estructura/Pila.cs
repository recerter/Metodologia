using Metodologia.Iterator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Metodologia.Estructura
{
    public class Pila : IColeccionable
    {
        readonly List<IComparable> elementos;
        public Pila()
        {
            elementos = new List<IComparable>();
        }

        public void Push(IComparable value)
        {
            elementos.Add(value);
        }
        public IComparable Pop()
        {
            var value = elementos[elementos.Count-1];
            elementos.RemoveAt(elementos.Count-1);
            return value;
        }
        public IComparable PopX(int puntero)
        {
            IComparable firstPila = this.elementos[puntero];
            return firstPila;
        }

        public IComparable Top()
        {
            return elementos[elementos.Count-1];
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
            foreach(IComparable e in elementos)
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
            foreach(IComparable e in elementos)
            {
                if (e.SosIgual(o))
                    return true;
            }
            return false;
        }

        public IIteradorColeccion CrearIterador()
        {
            return new IteradorPila(this);
        }
    }
}
