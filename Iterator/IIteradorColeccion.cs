using System;
using System.Collections.Generic;
using System.Text;

namespace Metodologia.Iterator
{
    public interface IIteradorColeccion
    {
        void First();
        object Next();
        bool End();
        object Get();
    }
}
