using Metodologia.Estructura;
using System;
using System.Collections.Generic;
using System.Text;

namespace Metodologia.Composite
{
    public class AlumnoCompuesto : Composite
    {
        private List<Alumno> ListAlumnosCompuestos;

        public AlumnoCompuesto(string nombre, int dni, int legajo, int calificacion) : base(nombre, dni, legajo, calificacion)
        {
            this.ListAlumnosCompuestos = new List<Alumno>();
        }
        public override void GetNombre()
        {
            Console.WriteLine("Componentes del compuesto");
            foreach (Alumno puntero in ListAlumnosCompuestos)
            {
                Console.WriteLine(puntero.Nombre);
            }
        }
        public override string MostrarCalificacion()
        {
            string calificacion="";
            foreach (Alumno puntero in ListAlumnosCompuestos)
            {
                calificacion += " " + puntero.Calificacion;
            }
            return calificacion;
        }

        public override int Responder(int pregunta)
        {
            List<int> respuestas = new List<int>();
            foreach (Composite puntero in ListAlumnosCompuestos)
            {
                respuestas.Add(puntero.Responder(pregunta));
            }

            return MaxCount(respuestas);
        }

        public override void SetCalificacion(int inCalificacion)
        {
            foreach (Composite elemento in ListAlumnosCompuestos)
            {
                elemento.SetCalificacion(inCalificacion);
            }
        }

        public override bool SosIgual(Alumno comparable)
        {
            bool verificacion = false;
            foreach (Composite elemento in ListAlumnosCompuestos)
            {
                verificacion = elemento.SosIgual(comparable);
            }
            return verificacion;
        }

        public override bool SosMayor(Alumno comparable)
        {
            bool verificacion = false;
            foreach (Composite elemento in ListAlumnosCompuestos)
            {
                verificacion = elemento.SosMayor(comparable);
            }
            return verificacion;
        }

        public override bool SosMenor(Alumno comparable)
        {
            bool verificacion = false;
            foreach (Composite elemento in ListAlumnosCompuestos)
            {
                verificacion = elemento.SosMenor(comparable);
            }
            return verificacion;
        }
        public void agregar(Alumno alumno)
        {
            ListAlumnosCompuestos.Add(alumno);
        }

        public void agregarAlumno(Alumno alumno)
        {
            ListAlumnosCompuestos.Add(alumno);
        }

        public void remover(Composite alumno)
        {
            ListAlumnosCompuestos.Remove(alumno);
        }
        private int MaxCount(List<int> lista)
        {
            lista.Sort();
            int contador = 0;
            int anterior = lista[0];
            int numeroMaximo = 0;
            int contadorAnterior = 0;
            for (int i = 1; i < lista.Count; i++)
            {
                if (anterior == lista[i])
                {
                    contador += 1;
                    anterior = lista[i];
                }
                else
                {
                    if (contadorAnterior < contador)
                        numeroMaximo = anterior;
                    contadorAnterior = contador;
                }
            }
            return numeroMaximo;
        }
    }

}
