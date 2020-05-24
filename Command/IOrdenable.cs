using System;
using System.Collections.Generic;
using System.Text;

namespace Metodologia.Command
{
    public interface IOrdenable
    {
        void SetOrdenInicio(IOrdenEnAula1 o);
        void SetOrdenLlegaAlumno(IOrdenEnAula2 o);
        void SetOrdenAulaLlena(IOrdenEnAula1 o);
    }
}
