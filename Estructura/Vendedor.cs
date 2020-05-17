using System;
using System.Collections.Generic;
using System.Text;
using Metodologia.Strategy;
using Metodologia.Observer;

namespace Metodologia.Estructura
{
    public class Vendedor:Persona, IComparable,IObservable
    {
        private double sueldoBasico;
        private double bonus;
        private double ultimaVenta;
        private List<IObservador> listaObservadores;
        

        public Vendedor(string nombre, int dni, double sueldoBasico) : base(nombre, dni)
        {
            this.sueldoBasico = sueldoBasico;
            this.bonus = 1;
            this.ListaObservadores = new List<IObservador>();
            base.Estrategia = new EstrategiaCompararBonus();
        }
        public List<IObservador> ListaObservadores
        {
            get
            {
                return this.listaObservadores;
            }
            set
            { 
                this.listaObservadores = value;
            }
        }

        public double SueldoBasico
        {
            get
            {
                return this.sueldoBasico;
            }
            set
            {
                this.sueldoBasico = value;
            }
        }
        public double Bonus
        {
            get
            {
                return this.bonus;
            }
            set
            {
                this.bonus = value;
            }
        }

        public double UltimaVenta
        {
            get
            {
                return this.ultimaVenta;
            }
            set
            {
                this.ultimaVenta = value;
            }
        }
        public void Venta(double monto)
        {
            this.ultimaVenta = monto;

            Console.WriteLine("El vendedor {0} ha concretado una venta por un valor de {1}.", this.Nombre, monto);
            Notificar();
        }

        public void AumentaBonus()
        {
            this.bonus += 0.1;
        }

        public void AgregarObservador(IObservador observador)
        {
            ListaObservadores.Add(observador);
        }

        public void QuitarObservador(IObservador observador)
        {
            ListaObservadores.Remove(observador);
        }

        public void Notificar()
        {
            foreach (IObservador observador in ListaObservadores)
            {
                observador.Actualizar(this);
            }
        }
    }
}
