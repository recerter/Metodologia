using System;
using System.Collections.Generic;
using System.Text;

namespace Metodologia.Estructura
{
    class ClaveValor : IComparable
    {
        public int clave;
        public IComparable valor;
        public ClaveValor(int clave, IComparable valor)
        {
            this.clave = clave;
            this.valor = valor;
        }
        public bool SosIgual(object comparable)
        {
            return this.valor.SosIgual(comparable);
        }

        public bool SosMayor(object comparable)
        {
            return this.valor.SosMayor(comparable);
        }

        public bool SosMenor(object comparable)
        {
            return this.valor.SosMenor(comparable);
        }
    }
}
