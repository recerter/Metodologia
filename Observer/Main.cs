using System;
using System.Collections.Generic;
using System.Text;
using Metodologia.Estructura;
using Metodologia.Iterator;
using Metodologia.FactoryMethod;
using Metodologia.Strategy;


namespace Metodologia.Observer
{
    public class Main
    {
        public static void Run()
        {
            Cola newCola = new Cola();
            FactoryMethod.Main.Llenar(newCola, 4); //Se le pasa el 4 ya que es la fabrica de Vendedores
            Gerente gerente = new Gerente();
            IIteradorColeccion iter = newCola.CrearIterador();
            while (!iter.End())
            {
                Vendedor elemento = (Vendedor)iter.Next();
                elemento.AgregarObservador(gerente);
            }
            JornadaDeVentas(newCola);
            gerente.Cerrar();

        }

        public static void JornadaDeVentas(IColeccionable o)
        {
            double monto;
            IIteradorColeccion iter = o.CrearIterador();
            while (!iter.End())
            {
                Vendedor elemento = (Vendedor)iter.Next();
                monto = new GeneradorDeDatosAleatorios().NumeroAleatorio(7000);
                elemento.Venta(monto);

            }
        }
    }
}
