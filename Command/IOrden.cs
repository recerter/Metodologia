using Metodologia.Estructura;
using System;
using System.Collections.Generic;
using System.Text;

namespace Metodologia.Command
{
    public interface IOrden
    {
        void Ejecutar(Alumno a);
    }
}
