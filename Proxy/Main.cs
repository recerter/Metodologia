using Metodologia.Adapter;
using Metodologia.FactoryMethod;
using System;
using System.Collections.Generic;
using System.Text;

namespace Metodologia.Proxy
{
    public class Main
    {
        public static void Run()
        {

            Teacher maestro = new Teacher();
            for (int i = 0; i < 10; i++)
            {
                Student adaptado = (AlumnoProxy)new FabricaDeAlumnosProxy().CrearAleatorio();
                maestro.goToClass(adaptado);
            }
            for (int i = 0; i < 10; i++)
            {
                Student adaptado = (AlumnoMuyEstudiosoProxy)new FabricaDeAlumnoMuyEstudiosoProxy().CrearAleatorio();
                maestro.goToClass(adaptado);
            }

            maestro.teachingAClass();

        }
    }
}
