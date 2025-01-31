using System;

namespace Others;

public class CalcularV2
{
    public void Calcular2()
    {
        double[] number = new double[2];

        Console.WriteLine("Ingrese el primer numero");
        number[0] = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese el primer numero");
        number[0] = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese un operador  '+' , '-', '/' ,'*' ");
        char operation = Console.ReadLine()[0];

        double resultado = 0;

        switch (operation)
        {
            case '+':
                resultado = number[0] + number[1];
                break;
            default:
                break;
        }
        Console.WriteLine($"El resultado es: {number[0]} {operation} {number[1]} = {resultado} ");
    }
}
