using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Threading.Tasks;
using Practicas;

namespace RubyPractics
{
    public class CalcularAreaCirculo()
    {
        public void CalcularArea()
        {
            Console.WriteLine("Ingrese el radio : \n");
            string input = Console.ReadLine();

            if (double.TryParse(input, out double radio))
            {
                // SALIDA
                double area = Area(radio);
                Console.WriteLine("La bendita area es: " + area);
            }
            else
            {
                Console.WriteLine("Parametros invalidos carnal");
            }
        }

        public static double Area(double radio)
        {
            // math.pow es mi double , 2 == exponente   // A = pi * radio al cuadrado

            return Math.PI * Math.Pow(radio, 2);
        }
    }
}

// A = pi * radio al cuadrado



// namespace RubyPractics
// {
//     class CalcularArea
//     {
//         public void Main()
//         {
//             Console.WriteLine("Ingrese el radio: ");
//             double radio = Convert.ToDouble(Console.ReadLine());

//             double area = CalcularAreaCirculo(radio);

//             Console.WriteLine("El area de un circulo es: " + area);
//         }

//         static double CalcularAreaCirculo(double radio)
//         {
//             return (Math.PI * radio);
//         }
//     }
// }
