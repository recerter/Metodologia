using System;
using System.Collections.Generic;
using System.Text;

namespace Metodologia.Observer
{
    public interface IObservable
    {
        public void AgregarObservador(IObservador observador);
        public void QuitarObservador(IObservador observador);
        public void Notificar();
    }
}
