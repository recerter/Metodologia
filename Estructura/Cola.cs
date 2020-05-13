using Metodologia.Iterator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Metodologia.Estructura
{
    public class Cola : IColeccionable
    {
        readonly List<object> elementos;
        public Cola()
        {
            elementos = new List<object>();
        }

        public void Push(object value)
        {
            elementos.Add(value);
        }
        public object Pop()
        {
            var value = elementos[0];
            elementos.RemoveAt(0);
            return value;
        }

        public object Top()
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

        public object Minimo()
        {
            object min = elementos[0];
            foreach (IComparable e in elementos)
            {
                if (e.SosMenor(min))
                    min = e;
            }
            return min;
        }

        public object Maximo()
        {
            object max = elementos[0];
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
