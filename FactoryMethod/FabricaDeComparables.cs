using System;
using System.Collections.Generic;
using System.Text;
using Metodologia.ChainOfResponsability;
using Metodologia.Estructura;

namespace Metodologia.FactoryMethod
{
    public abstract class FabricaDeComparables
    {
        public static Estructura.IComparable CrearAleatorio(int opc)
        {
            Manejadores generador = new LectorDeDatos(null);
            generador = GeneradorDeDatosAleatorios.getInstance(generador);
            generador = LectorDeArchivos.getInstance(generador);
            FabricaDeComparables factory = null;
            switch (opc)
            {
                case 1:
                    factory = new FabricaDeAlumnoCompuesto(generador.StringAleatorio(6), (int)generador.NumeroDesdeArchivo(990000), generador.NumeroAleatorio(99999), generador.NumeroAleatorio(10));
                    break;
                    
            }
            return factory.CrearComparable();
        }
        public abstract Estructura.IComparable CrearPorTeclado();
        public abstract Estructura.IComparable CrearComparable();
    }
}
