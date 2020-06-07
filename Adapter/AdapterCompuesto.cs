using System;
using System.Collections.Generic;
using System.Text;

namespace Metodologia.Adapter
{
    public class AdapterCompuesto : Student
    {
        AdapterComposite adaptado;

        public AdapterCompuesto(AdapterComposite adaptar)
        {
            adaptado = adaptar;
        }
        public bool equals(Student student)
        {
            return adaptado.nombre == student.getName();
        }

        public string getName()
        {
            return adaptado.nombre;
        }

        public bool greaterThan(Student student)
        {
            throw new NotImplementedException();
        }

        public bool lessThan(Student student)
        {
            throw new NotImplementedException();
        }

        public void setScore(int score)
        {
            throw new NotImplementedException();
        }

        public string showResult()
        {
            throw new NotImplementedException();
        }

        public int yourAnswerIs(int question)
        {
            throw new NotImplementedException();
        }
    }
}
