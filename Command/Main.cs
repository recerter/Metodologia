using Metodologia.Estructura;
using Metodologia.FactoryMethod;
using System;
using System.Collections.Generic;
using System.Text;


namespace Metodologia.Command
{
    public class Main
    {
        public static void Run()
        {
            Cola p = new Cola();
            Aula a = new Aula();
            p.SetOrdenInicio(new OrdenInicio(a));
            p.SetOrdenLlegaAlumno(new OrdenLlegaAlumno(a));
            p.SetOrdenAulaLlena(new OrdenAulaLlena(a));
            Llenar(p, 1);
            Llenar(p, 2);
            Iterator.Main.ImprimirElementos(p);
        }
        public static void Llenar(IColeccionable coleccion, int eleccion)
        {
            switch (eleccion)
            {
                case 1:
                    for (int i = 0; i < 20; i++)
                    {
                        coleccion.Agregar(new FabricaDeAlumnos().CrearAleatorio());
                    }
                    break;
                case 2:
                    for (int i = 0; i < 20; i++)
                    {
                        coleccion.Agregar(new FabricaDeAlumnoMuyEstudioso().CrearAleatorio());
                    }
                    break;
            }
        }
    }
}
