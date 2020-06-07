using Metodologia.Adapter;
using Metodologia.Proxy;
using Metodologia.FactoryMethod;
using System;
using System.Collections.Generic;
using System.Text;
using Metodologia.Estructura;

namespace Metodologia.Composite
{
    public class Main
    {
        public static void Run()
        {
            Teacher maestro = new Teacher();

            AlumnoCompuesto alumnoCompuesto = (AlumnoCompuesto)new FabricaDeAlumnoCompuesto().CrearAleatorio();
            AlumnoProxy alumno1 = (AlumnoProxy)new FabricaDeAlumnosProxy().CrearAleatorio();
            AlumnoProxy alumno2 = (AlumnoProxy)new FabricaDeAlumnosProxy().CrearAleatorio();
            AlumnoProxy alumno3 = (AlumnoProxy)new FabricaDeAlumnosProxy().CrearAleatorio();
            AlumnoProxy alumno4 = (AlumnoProxy)new FabricaDeAlumnosProxy().CrearAleatorio();
            AlumnoProxy alumno5 = (AlumnoProxy)new FabricaDeAlumnosProxy().CrearAleatorio();

             alumnoCompuesto.agregar(alumno1);
             alumnoCompuesto.agregar(alumno2);
            alumnoCompuesto.agregar(alumno3);
            alumnoCompuesto.agregar(alumno4);
            alumnoCompuesto.agregar(alumno5);
          Student estudiante = new AdapterStudent(alumnoCompuesto);
            maestro.goToClass(estudiante);
            maestro.teachingAClass();
            Console.WriteLine("Imprimiendo compuesto");
            alumnoCompuesto.GetNombre();
            Console.WriteLine("Fin Imprimiendo compuesto");
        }
    }
}
