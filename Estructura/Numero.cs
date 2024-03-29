﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Metodologia.Estructura
{
    public class Numero : IComparable
    {
        private int valor;

        public Numero(int valor)
        {
            this.valor = valor;
        }

        public int Valor
        {
            get
            {
                return this.valor;
            }
            set
            {
                this.valor = value;
            }
        }

        public bool SosIgual(IComparable o)
        {
            Numero n = o as Numero;
            return Valor == n.Valor;
        }

        public bool SosMayor(IComparable o)
        {
            Numero n = o as Numero;
            return Valor > n.Valor;
        }

        public bool SosMenor(IComparable o)
        {
            Numero n = o as Numero;
            return Valor < n.Valor;
        }

        public override string ToString()
        {
            return string.Format("[Numero Valor= {0}]", valor);
        }
    }
}
