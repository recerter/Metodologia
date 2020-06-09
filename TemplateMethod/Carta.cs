using Metodologia.Iterator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Metodologia.TemplateMethod
{
    public class Carta: Estructura.IComparable
    {
        public int Valor { get; set; }
        public string Simbolo { get; set; }
        public int PesoSimbolo { get; set; }
        public int Prioridad { get; set; }
        public Carta(int valor, int pesoSimbolo)
        {
            Valor = valor;
            PesoSimbolo = pesoSimbolo;
            if (PesoSimbolo.Equals(1)) Simbolo = "Espada";
            else if (PesoSimbolo.Equals(2)) Simbolo = "Basto";
            else if (PesoSimbolo.Equals(3)) Simbolo = "Oro";
            else if (PesoSimbolo.Equals(4)) Simbolo = "Copa";
            else Simbolo = "Comodin";
        }
        public bool SosIgual(Estructura.IComparable o)
        {
            Type tipo = o.GetType();
            Type obj = this.GetType();
            if (tipo.Equals(obj))
            {
                return Prioridad.Equals(((Carta)o).Prioridad) ? true : false;
            }
            return false;
        }

        public bool SosMayor(Estructura.IComparable o)
        {
            Type tipo = o.GetType();
            Type obj = this.GetType();
            if (tipo.Equals(obj))
            {
                return Prioridad > ((Carta)o).Prioridad ? true : false;
            }
            return false;
        }

        public bool SosMenor(Estructura.IComparable o)
        {
            Type tipo = o.GetType();
            Type obj = this.GetType();
            if (tipo.Equals(obj))
            {
                return Prioridad < ((Carta)o).Prioridad ? true : false;
            }
            return false;
        }

        public override string ToString()
        {
            return string.Format("[Carta: {0} {1}]", Valor, Simbolo);
        }
    }
}
