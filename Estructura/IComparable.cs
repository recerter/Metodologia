using System;
using System.Collections.Generic;
using System.Text;

namespace Metodologia.Estructura
{
    public interface IComparable
    {
        public bool SosIgual(object o);
        public bool SosMenor(object o);
        public bool SosMayor(object o);
    }
}
