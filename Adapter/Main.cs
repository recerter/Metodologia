using System;
using System.Collections.Generic;
using System.Text;
using Metodologia.Estructura;
using Metodologia.FactoryMethod;

namespace Metodologia.Adapter
{
    public class Main
    {
        public static void Run()
        {
            Teacher maestro = new Teacher();
            for (int i = 0; i < 10; i++)
            {
                Student adaptado = new AdapterStudent((Alumno)new FabricaDeAlumnos().CrearAleatorio());
                maestro.goToClass(adaptado);
            }
            for (int i = 0; i < 10; i++)
            {
                Student adaptado = new AdapterStudent((AlumnoMuyEstudioso)new FabricaDeAlumnoMuyEstudioso().CrearAleatorio());
                maestro.goToClass(adaptado);
            }

            maestro.teachingAClass();
        }
    }
}
