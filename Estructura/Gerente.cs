using Metodologia.Observer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Metodologia.Estructura
{
    public class Gerente:IObservador
    {
        private List<Vendedor> mejores;

        public Gerente()
        {
            Mejores = new List<Vendedor>();
        }
        public List<Vendedor> Mejores { get { return mejores; } set { mejores = value; } }

        public void Actualizar(IObservable observado)
        {
            Vendedor vendedorObservado = (Vendedor)observado;
            Venta(vendedorObservado.UltimaVenta, vendedorObservado);
        }

        public void Cerrar()
        {
            Console.WriteLine("La lista de los Mejores Vendedores es: ");
            foreach (Vendedor elemento in Mejores)
            {
                Console.WriteLine("{0} sumo un bonus de : {1}.", elemento.Nombre, elemento.Bonus);
            }
        }

        public void Venta(double monto, Vendedor vendedor)
        {
            if (monto > 5000)
            {
                if (!Mejores.Contains(vendedor))
                {
                    Mejores.Add(vendedor);
                }
                vendedor.AumentaBonus();
            }
        }
    }
}
