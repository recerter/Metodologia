/*
 * Created by Metodologías de Programación I
 * Activity 7. 
 * Chain of responsability and Singleton patterns 
 *
 * Antes de usar este código el alumno deberá agregar a la variable "ruta_archivo" de la clase 
 * "LectorDeArchivos" la ruta correspondiente a su equipo donde haya guardado el archvo con los datos
 * provistos por la cátedra (archivo datos.txt)
 *
 * IMPORTANTE *  
 * El código que está en este archivo SI puede modificarse para resolver la actividad solicitada
 * 
 */

using System;
using System.IO;
using Metodologia.Estructura;

namespace Metodologia.ChainOfResponsability
{
	public class LectorDeArchivos : Manejadores
	{
        private static LectorDeArchivos Lector { get; set; }
        // El alumno deberá agregar la ruta correspondiente a su equipo donde haya guardado el archvo con los datos
        private const string ruta_archivo = @"E:\VisualStudio\repos\Metodologia\ChainOfResponsability\datos.txt";
		// --------------------------------------------------------------------------------------------------------

		private StreamReader lector_de_archivos;

		public LectorDeArchivos(Manejadores Sucesor) : base(Sucesor)
		{
			lector_de_archivos = new StreamReader(ruta_archivo);
		}
        public static LectorDeArchivos getInstance(Manejadores Sucesor)
        {
            if (Lector == null)
                Lector = new LectorDeArchivos(Sucesor);
            return Lector;
        }

        public override int NumeroAleatorio(int limite)
        {
            if (Sucesor != null)
                return Sucesor.NumeroAleatorio(limite);
            return 0;
        }

        public override double NumeroDesdeArchivo(double max)
        {
            string linea = lector_de_archivos.ReadLine();
            return Double.Parse(linea.Substring(0, linea.IndexOf('\t'))) * max;
        }

        public override int NumeroPorTeclado()
        {
            if (Sucesor != null)
                return Sucesor.NumeroPorTeclado();
            return 0;
        }

        public override string StringAleatorio(int cantidad_chr)
        {
            if (Sucesor != null)
                return Sucesor.StringAleatorio(cantidad_chr);
            return "";
        }

        public override string StringDesdeArchivo(int cant)
		{
			string linea = lector_de_archivos.ReadLine();
			linea = linea.Substring(linea.IndexOf('\t') + 1);
			cant = Math.Min(cant, linea.Length);
			return linea.Substring(0, cant);
		}

        public override string StringPorTeclado()
        {
            if (Sucesor != null)
                return Sucesor.StringPorTeclado();
            return "";
        }
    }
}