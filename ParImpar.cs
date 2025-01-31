using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Practicas;

/*

Crea una función bool EsPar(int numero) que retorne true si el número es
par y false si no lo es*/


namespace RubyPractics
{
    public class ParImpar
    {
        bool salida = false;

        public void ParImpares()
        {
            Console.WriteLine("Ingrese el numero que quiere validar");
            string input = Console.ReadLine();

            if (double.TryParse(input, out double numero))
            {
                salida = (numero % 2 == 0) ? true : false;
                if (salida == true)
                {
                    Console.WriteLine($"El {numero} es Par : " + salida);
                }
                else if (salida == false)
                {
                    Console.WriteLine($"El {numero} es Impar : " + salida);
                }
            }
            else
            {
                Console.WriteLine("Dato invalido");
            }
        }
    }
}
