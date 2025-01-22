using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Others
{
    public class Notas
    {
        public void NotasEscolares()
        {
            Console.WriteLine("Ingrese Su nota --(A,B,C,D,E,F)-- ");
            string? input = Console.ReadLine().ToUpper();

            if (!string.IsNullOrEmpty(input) && input.Length == 1)
            {
                char nota = input[0];
                switch (nota)
                {
                    case 'A':
                        Console.WriteLine("Aprobado 100-90");
                        break;
                    case 'B':
                        Console.WriteLine("Aprobado 90-80 ");
                        break;
                    case 'C':
                        Console.WriteLine("Aprobado con un buen 75... xD.. ");
                        break;
                    case 'D':
                        Console.WriteLine("Aprobado Gateando.. ");
                        break;
                    case 'F':
                        Console.WriteLine("Quemado!.. Ponte a estudiar!");
                        break;

                    default:
                        Console.WriteLine("Calificación no valida... Ingrese : A, B, C, D, E o F ");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Que es eso?.. Una sola letra..");
            }
            { }
        }
    }
}


// Haz un switch que, dada una calificación (A, B, C, D, E, F), muestre un
// mensaje distinto para cada caso.
