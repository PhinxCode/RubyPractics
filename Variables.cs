using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// (int, float, string, bool)
namespace Practicas
{
    public class Variables
    {
        public void MostrarVariables()
        {
            int numbInt = 1;
            float numbFloat = 1.1f;
            string text = "TXT";
            bool booleano = true;

            Console.WriteLine("Entero es igual a : " + numbInt);
            Console.WriteLine("Flotante es igual a : " + numbFloat);
            Console.WriteLine("String es igual a : " + text);
            Console.WriteLine("Booleano es igual a : " + booleano);
        }
    }
}
