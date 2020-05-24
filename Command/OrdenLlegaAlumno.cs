using Metodologia.Estructura;
using System;
using System.Collections.Generic;
using System.Text;

namespace Metodologia.Command
{
    public class OrdenLlegaAlumno:IOrdenEnAula2
    {
        Aula a;
        public OrdenLlegaAlumno(Aula a)
        {
            this.a = a;
        }
        public void Ejecutar(Estructura.IComparable o)
        {
            a.NuevoAlumno((Alumno)o);
        }

        
    }
}
