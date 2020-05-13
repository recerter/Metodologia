using System;
using System.Collections.Generic;
using System.Text;
using Metodologia.Iterator;

namespace Metodologia.Estructura
{
    public interface IColeccionable : IIterador
    {
        public int Cuantos();
        public IComparable Minimo();
        public IComparable Maximo();
        public void Agregar(IComparable o);
        public bool Contiene(IComparable o);
    }
}
