using System;
using System.Collections.Generic;
using System.Text;

namespace Metodologia.Esructura
{
    public interface IComparable
    {
        public bool sosIgual(IComparable o);
        public bool sosMenor(IComparable o);
        public bool sosMayor(IComparable o);
    }
}
