using Metodologia.Adapter;
using Metodologia.Estructura;
using Metodologia.Proxy;
using Metodologia.FactoryMethod;
using System;
using System.Collections.Generic;
using System.Text;
using Metodologia.Composite;

namespace Metodologia.ChainOfResponsability
{
    public class Main
    {
        public static void Run()
        {
            Teacher maestro = new Teacher();

            AlumnoCompuesto alumnoCompuesto = (AlumnoCompuesto)new FabricaDeAlumnoCompuesto().CrearAleatorio();
            AlumnoProxy alumnoProxy1 = (AlumnoProxy)new FabricaDeAlumnosProxy().CrearAleatorio();
            AlumnoProxy alumnoProxy2 = (AlumnoProxy)new FabricaDeAlumnosProxy().CrearAleatorio();
            AlumnoProxy alumnoProxy3 = (AlumnoProxy)new FabricaDeAlumnosProxy().CrearAleatorio();
            AlumnoProxy alumnoProxy4 = (AlumnoProxy)new FabricaDeAlumnosProxy().CrearAleatorio();
            AlumnoProxy alumnoProxy5 = (AlumnoProxy)new FabricaDeAlumnosProxy().CrearAleatorio();

            Alumno alumno1 = (Alumno)new FabricaDeAlumnos().CrearAleatorio();
            Alumno alumno2 = (Alumno)new FabricaDeAlumnos().CrearAleatorio();
            Alumno alumno3 = (Alumno)new FabricaDeAlumnos().CrearAleatorio();
            Alumno alumno4 = (Alumno)new FabricaDeAlumnos().CrearAleatorio();
            Alumno alumno5 = (Alumno)new FabricaDeAlumnos().CrearAleatorio();

            AlumnoMuyEstudioso alumnoME1 = (AlumnoMuyEstudioso)new FabricaDeAlumnoMuyEstudioso().CrearAleatorio();
            AlumnoMuyEstudioso alumnoME2 = (AlumnoMuyEstudioso)new FabricaDeAlumnoMuyEstudioso().CrearAleatorio();
            //AlumnoMuyEstudioso alumnoME1 = (AlumnoMuyEstudioso)new FabricaDeAlumnoMuyEstudioso().CrearPorTeclado();
            //AlumnoMuyEstudioso alumnoME2 = (AlumnoMuyEstudioso)new FabricaDeAlumnoMuyEstudioso().CrearPorTeclado();

            alumnoCompuesto.agregar(alumnoProxy1);
            alumnoCompuesto.agregar(alumnoProxy2);
            alumnoCompuesto.agregar(alumnoProxy3);
            alumnoCompuesto.agregar(alumnoProxy4);
            alumnoCompuesto.agregar(alumnoProxy5);

            Student estudiante = new AdapterStudent(alumnoCompuesto);
            maestro.goToClass(estudiante);
            estudiante = new AdapterStudent(alumno1);
            maestro.goToClass(estudiante);
            estudiante = new AdapterStudent(alumno2);
            maestro.goToClass(estudiante);
            estudiante = new AdapterStudent(alumno3);
            maestro.goToClass(estudiante);
            estudiante = new AdapterStudent(alumno4);
            maestro.goToClass(estudiante);
            estudiante = new AdapterStudent(alumno5);
            maestro.goToClass(estudiante);

            estudiante = new AdapterStudent(alumnoME1);
            maestro.goToClass(estudiante);
            estudiante = new AdapterStudent(alumnoME2);
            maestro.goToClass(estudiante);

            maestro.teachingAClass();
        }
    }
}
