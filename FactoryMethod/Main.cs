using System;
using System.Collections.Generic;
using System.Text;
using Metodologia.ChainOfResponsability;
using Metodologia.Estructura;

namespace Metodologia.FactoryMethod
{
    public class Main
    {

        public static void Llenar(IColeccionable o, int eleccion)
        {
            // Elecciones: Persona(1) / Alumno(2) / Numeros(3) / Vendedores(4)
            switch (eleccion)
            {
                case 1:
                    Manejadores generador = new LectorDeDatos(null);
                    generador = GeneradorDeDatosAleatorios.getInstance(generador);
                    generador = LectorDeArchivos.getInstance(generador);
                    for (int i = 0; i < 20; i++)
                    {
                        o.Agregar(new Persona(generador.StringAleatorio(15), generador.NumeroAleatorio(9)));
                    }
                    break;
                case 2:
                    for (int i = 0; i < 20; i++)
                    {
                        o.Agregar(new FabricaDeAlumnos().CrearAleatorio());
                    }
                    break;
                case 3:
                    for (int i = 0; i < 20; i++)
                    {
                        o.Agregar(new FabricaDeNumeros().CrearAleatorio());
                    }
                    break;
                case 4: 
                    for (int i = 0; i < 20; i++)
                    {
                        o.Agregar(new FabricaDeVendedores().CrearAleatorio());
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
