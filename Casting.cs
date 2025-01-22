using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RubyPractics
{
    public class Casting
    {
        public void changeValue()
        {
            double value = 13.4;
            int entero = (int)value;

            Console.WriteLine($"El valor de {value}  cambio a entero {entero}");
        }
    }
}
