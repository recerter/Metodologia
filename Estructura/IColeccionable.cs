using System;
using System.Collections.Generic;
using System.Text;

namespace Metodologia.Esructura
{
    public interface IColeccionable
    {
        public int Cuantos();
        public IComparable Minimo();
        public IComparable Maximo();
        public void Agregar(IComparable o);
        public bool Contiene(IComparable o);
    }
}
