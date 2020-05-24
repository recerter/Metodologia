using Metodologia.Adapter;
using Metodologia.Command;
using Metodologia.Iterator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Metodologia.Estructura
{
    public class Aula
    {
        public Teacher teacher;
        
        public void Comenzar()
        {
            Console.WriteLine("Comineza La clase");
            teacher = new Teacher();
        }
        public void NuevoAlumno(Alumno Nuevo)
        {
            teacher.goToClass(new AdapterStudent(Nuevo));
        }
        public void ClaseLista()
        {
            teacher.teachingAClass();
        }
    }
}
