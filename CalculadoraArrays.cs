using System;

namespace Others;

public class CalculadoraArrays
{
    public void Calcular()
    {
        /*** calculadora con arrays */







        double[] number = new double[2];

        Console.WriteLine("Ingrese el primer número");

        number[0] = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo número");

        number[1] = Convert.ToDouble(Console.ReadLine());

        /*** CHAR PARA no escribir tanto xD */

        Console.Write("Ingresa el operador (+, -, *, / ): ");
        char operador = Console.ReadLine()[0];

        double resultado = 0;

        switch (operador)
        {
            case '+':
                resultado = number[0] + number[1];
                break;

            case '-':
                resultado = number[0] - number[1];
                break;
            case '*':
                resultado = number[0] * number[1];
                break;
            case '/':

                if (number[1] != 0)
                {
                    Console.WriteLine("No puedes dividir entre 0");

                    return;
                }
                resultado = number[0] / number[1];
                break;

            default:
                Console.WriteLine("Operador invalido, Limitese a usar el operador");
                break;
        }
        Console.WriteLine($"El resultado es: {number[0]} {operador} {number[1]} = {resultado} ");
    }
}
