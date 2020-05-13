﻿using System;
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
        public bool SosIgual(IComparable comparable)
        {
            return this.valor.SosIgual(comparable);
        }

        public bool SosMayor(IComparable comparable)
        {
            return this.valor.SosMayor(comparable);
        }

        public bool SosMenor(IComparable comparable)
        {
            return this.valor.SosMenor(comparable);
        }
    }
}
