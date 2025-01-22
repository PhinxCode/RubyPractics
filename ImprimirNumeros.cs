using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Others
{
    public class ImprimirNumeros
    {
        public void ImprimirFor()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Número : " + i);
            }
        }

        public void ImprimirWhile()
        {
            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine("Número: " + i);
                i++;
            }
        }

        public void ImprimirDoWhile()
        {
            int i = 1;

            do
            {
                Console.WriteLine("Número: " + i);
                i++;
            } while (i <= 10);
        }
    }
}

// Escribe un programa que imprima los números del 1 al 10 usando for, luego
// while y finalmente do-while.
