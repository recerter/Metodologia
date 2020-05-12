using System;
using System.Collections.Generic;
using System.Text;

namespace Metodologia.Esructura
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
                if (e.sosMenor(min))
                    min = e;
            }
            return min;
        }

        public IComparable Maximo()
        {
            IComparable max = elementos[0];
            foreach (IComparable e in elementos)
            {
                if (e.sosMayor(max))
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
                if (e.sosIgual(o))
                    return true;
            }
            return false;
        }
    }
}
