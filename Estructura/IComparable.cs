using System;
using System.Collections.Generic;
using System.Text;

namespace Metodologia.Esructura
{
    public interface IComparable
    {
        bool sosIgual(IComparable o);
        bool sosMenor(IComparable o);
        bool sosMayor(IComparable o);
    }
}
