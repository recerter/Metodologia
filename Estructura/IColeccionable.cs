using System;
using System.Collections.Generic;
using System.Text;

namespace Metodologia.Esructura
{
    interface IColeccionable
    {
        int Cuantos();
        IComparable Minimo();
        IComparable Maximo();
        void Agregar(IComparable o);
        bool Contiene(IComparable o);
    }
}
