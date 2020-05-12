﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Metodologia.Esructura
{
    public class Persona :IComparable
    {
        private string nombre;
        private int dni;

        public Persona(string nombre, int dni)
        {
            this.nombre = nombre;
            this.dni = dni;
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        public int Dni
        {
            get
            {
                return this.dni;
            }
            set
            {
                this.dni = value;
            }
        }

        public bool sosIgual(IComparable o)
        {
            Persona n = o as Persona;
            return Dni == n.Dni;
        }

        public bool sosMenor(IComparable o)
        {
            Persona n = o as Persona;
            return Dni < n.Dni;
        }

        public bool sosMayor(IComparable o)
        {
            Persona n = o as Persona;
            return Dni > n.Dni;
        }
        public override string ToString()
        {
            return string.Format("[Persona Nombre={0} DNI= {1}]", nombre, dni);
        }
    }
}
