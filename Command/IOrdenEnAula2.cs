using Metodologia.Estructura;
using System;
using System.Collections.Generic;
using System.Text;

namespace Metodologia.Command
{
    public interface IOrdenEnAula2
    {
        void Ejecutar(Estructura.IComparable o);
    }
}
