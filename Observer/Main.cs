using System;
using System.Collections.Generic;
using System.Text;
using Metodologia.Estructura;
using Metodologia.Iterator;
using Metodologia.FactoryMethod;
using Metodologia.Strategy;
using Metodologia.ChainOfResponsability;

namespace Metodologia.Observer
{
    public class Main
    {
        public static void Run()
        {
            Cola newCola = new Cola();
            FactoryMethod.Main.Llenar(newCola, 4); //4 Fabrica de Vendedores
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
            Manejadores generador = new LectorDeDatos(null);
            generador = GeneradorDeDatosAleatorios.getInstance(generador);
            while (!iter.End())
            {
                Vendedor elemento = (Vendedor)iter.Next();
                monto = generador.NumeroAleatorio(7000);
                elemento.Venta(monto);

            }
        }
    }
}
