using Metodologia.Estructura;
using System;
using System.Collections.Generic;
using System.Text;

namespace Metodologia.Command
{
    public class OrdenInicio : IOrdenEnAula1
    {
        Aula a;
        public OrdenInicio(Aula a)
        {
            this.a = a;
        }
        public void Ejecutar()
        {
            a.Comenzar();
        }
    }
}
