using System;
using System.Collections.Generic;
using System.Text;

namespace Metodologia.Estructura
{
    public interface IColeccionable
    {
        public int Cuantos();
        public object Minimo();
        public object Maximo();
        public void Agregar(IComparable o);
        public bool Contiene(IComparable o);
    }
}
