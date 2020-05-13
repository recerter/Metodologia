using Metodologia.Iterator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Metodologia.Estructura
{
    public class Diccionario : IColeccionable
    {
        readonly Conjunto conjunto;
        int clave = 0;
        public Diccionario()
        {
            conjunto = new Conjunto();
        }
        public void Agregar(int clave, IComparable valor)
        {
            ClaveValor cv = new ClaveValor(clave, valor);
            conjunto.Agregar(cv);
        }

        public object ValorDe(object clave)
        {
            foreach(ClaveValor cv in conjunto.Almacenamiento)
            {
                if (clave.Equals(cv.clave))
                {
                    return cv.valor;
                }
            }
            return null;
        }
        public void Agregar(IComparable o)
        {
            if (!conjunto.Pertenece(clave))
            {
                Agregar(clave, o);
                clave++;
            }
        }
        public bool Contiene(IComparable o)
        {
            foreach (IComparable v in conjunto.Almacenamiento)
            {
                if (v.SosIgual(o))
                    return true;
            }
            return false;
        }

        public int Cuantos()
        {
            return conjunto.Almacenamiento.Count;
        }

        public IComparable Maximo()
        {
            IComparable max = (IComparable)(conjunto.Almacenamiento[0]);
            foreach (IComparable v in conjunto.Almacenamiento)
            {
                if (v.SosMayor(max))
                    max = v;
            }
            return max;
        }

        public IComparable Minimo()
        {
            IComparable min = (IComparable)(conjunto.Almacenamiento[0]);
            foreach (IComparable v in conjunto.Almacenamiento)
            {
                if (v.SosMenor(min))
                    min = v;
            }
            return min;
        }

        public IIteradorColeccion CrearIterador()
        {
            return new IteradorDiccionario(this);
        }
    }
}
