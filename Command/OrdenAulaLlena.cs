using Metodologia.Estructura;
using System;
using System.Collections.Generic;
using System.Text;

namespace Metodologia.Command
{
    public class OrdenAulaLlena : IOrdenEnAula1
    {
        public Aula a;
        public OrdenAulaLlena(Aula a)
        {
            this.a = a;
        }
        public void Ejecutar()
        {
            a.ClaseLista();
        }
    }
}
