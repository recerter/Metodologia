using System;
using System.Collections.Generic;
using System.Text;
using Metodologia.Estructura;

namespace Metodologia.FactoryMethod
{
    class FabricaDeAlumnos : IFabricaDeComparables
    {
        public Estructura.IComparable CrearAleatorio()
        {
            GeneradorDeDatosAleatorios random = new GeneradorDeDatosAleatorios();
            return new Alumno(random.StringAleatorio(6), Convert.ToInt32(random.NumeroAleatorio(99999)), Convert.ToInt32(random.NumeroAleatorio(99999)), Convert.ToInt32(random.NumeroAleatorio(10)));
        }

        public Estructura.IComparable CrearPorTeclado()
        {
            Console.Write("\nIngrese un Nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("\nIngrese un Documento: ");
            string documento = Console.ReadLine();
            Console.Write("\nIngrese un Legajo: ");
            string legajo = Console.ReadLine();
            Console.Write("\nIngrese un Promedio: ");
            string promedio = Console.ReadLine();

            return new Alumno(nombre, Convert.ToInt32(documento), Convert.ToInt32(legajo), Convert.ToInt32(promedio));
        }
    }
}
