﻿using Metodologia.Iterator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Metodologia.Estructura
{
    public class Conjunto : IColeccionable
    {
        private List<IComparable> almacenamiento;
        public List<IComparable> Almacenamiento { get { return almacenamiento; } private set { this.almacenamiento = value; } }

        public Conjunto()
        {
            almacenamiento = new List<IComparable>();
        }
        public void Agregar(IComparable elemento)
        {
            if (Pertenece(elemento).Equals(false))
                almacenamiento.Add(elemento);
        }
        public bool Pertenece(object elemento)
        {
            bool pertenece = false;
            foreach (object puntero in almacenamiento)
            {
                if (pertenece.Equals(false))
                    pertenece = puntero.Equals(elemento) ? true : false;
            }
            return pertenece;
        }
        public bool Contiene(IComparable o)
        {
            foreach (object elemento in almacenamiento)
            {
                if (elemento.Equals(o))
                    return true;
            }
            return false;
        }

        public int Cuantos()
        {
            return this.almacenamiento.Count;
        }

        public IComparable Maximo()
        {
            IComparable max = almacenamiento[0];
            foreach (IComparable e in almacenamiento)
            {
                if (e.SosMayor(max))
                    max = e;
            }
            return max;
        }

        public IComparable Minimo()
        {
            IComparable min = almacenamiento[0];
            foreach (IComparable e in almacenamiento)
            {
                if (e.SosMenor(min))
                    min = e;
            }
            return min;
        }

        public IIteradorColeccion CrearIterador()
        {
            return new IteradorConjunto(this);
        }
        
    }
}
