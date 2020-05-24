using Metodologia.Command;
using Metodologia.Iterator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Metodologia.Estructura
{
    public class Cola : IColeccionable, IOrdenable, IIterador
    {
        readonly List<IComparable> elementos;
        public IOrdenEnAula1 OrdenInicioEnAula;
        public IOrdenEnAula1 OrdenEnAulaLlena;
        public IOrdenEnAula2 OrdenLlegaAlumno;
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
            if (this.elementos.Count.Equals(0))
                OrdenInicioEnAula.Ejecutar();

            this.elementos.Add(o);
            OrdenLlegaAlumno.Ejecutar(o);

            if (this.elementos.Count.Equals(39))
                OrdenEnAulaLlena.Ejecutar();
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

        public void SetOrdenInicio(IOrdenEnAula1 o)
        {
            OrdenInicioEnAula = o;

        }

        public void SetOrdenLlegaAlumno(IOrdenEnAula2 o)
        {
            OrdenLlegaAlumno = o;
        }

        public void SetOrdenAulaLlena(IOrdenEnAula1 o)
        {
            OrdenEnAulaLlena = o;
        }
    }
}
