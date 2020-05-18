using System;
using System.Collections.Generic;
using System.Text;
using Metodologia.Estructura;

namespace Metodologia.FactoryMethod
{
    class FabricaDeAlumnoMuyEstudioso : IFabricaDeComparables
    {
        public Estructura.IComparable CrearAleatorio()
        {
            GeneradorDeDatosAleatorios random = new GeneradorDeDatosAleatorios();
            AlumnoMuyEstudioso registro = new AlumnoMuyEstudioso(random.StringAleatorio(6), Convert.ToInt32(random.NumeroAleatorio(99999)), Convert.ToInt32(random.NumeroAleatorio(99999)), Convert.ToInt32(random.NumeroAleatorio(10)));
            registro.Calificacion = Convert.ToDouble(random.NumeroAleatorio(10));
            return registro;
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
            AlumnoMuyEstudioso registro = new AlumnoMuyEstudioso(nombre, Convert.ToInt32(documento), Convert.ToInt32(legajo), Convert.ToInt32(promedio));
            Console.Write("Por favor, ingrese una Calificacion: ");
            string calificacion = Console.ReadLine();
            registro.Calificacion = Convert.ToDouble(calificacion);
            return registro;
        }
    }
}
