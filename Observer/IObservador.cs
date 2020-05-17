using System;
using System.Collections.Generic;
using System.Text;

namespace Metodologia.Observer
{
    public interface IObservador
    {
        public void Actualizar(IObservable observado);
    }
}
