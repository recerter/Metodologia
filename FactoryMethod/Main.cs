using System;
using System.Collections.Generic;
using System.Text;
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
                    for (int i = 0; i < 20; i++)
                    {
                        o.Agregar(new Persona(new GeneradorDeDatosAleatorios().StringAleatorio(15), new GeneradorDeDatosAleatorios().NumeroAleatorio(9)));
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
