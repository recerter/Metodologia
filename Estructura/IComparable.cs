using System;
using System.Collections.Generic;
using System.Text;

namespace Metodologia.Estructura
{
    public interface IComparable
    {
        public bool SosIgual(IComparable o);
        public bool SosMenor(IComparable o);
        public bool SosMayor(IComparable o);
    }
}
