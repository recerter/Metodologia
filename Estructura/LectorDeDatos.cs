using System;
using System.Collections.Generic;
using System.Text;

namespace Metodologia.Estructura
{
    class LectorDeDatos
    {
        public int NumeroPorTeclado()
        {
            int in_number = Convert.ToInt32(Console.ReadLine());
            return in_number;
        }

        public string StringPorTeclado()
        {
            string in_string = Console.ReadLine();
            return in_string;
        }
    }
}
