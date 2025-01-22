using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practicas
{
    public class Calculadora
    {
        public void Calculos()
        {
            Console.WriteLine("Bienvenido");

            Console.WriteLine("Elige una opcion : ");
            Console.WriteLine("1.Suma");
            Console.WriteLine("2.Resta");
            Console.WriteLine("3.División");
            Console.WriteLine("4.Multiplicación");

            string? operation = Console.ReadLine();

            if (
                string.IsNullOrEmpty(operation)
                || !int.TryParse(operation, out int op)
                || op < 1
                || op > 4
            )
            {
                Console.WriteLine("Ingrese un número válido entre 1 y 4.");
                return;
            }

            string operationName = "";

            switch (operation)
            {
                case "1":
                    operationName = "suma";
                    break;
                case "2":
                    operationName = "Resta";
                    break;
                case "3":
                    operationName = "División";
                    break;
                case "4":
                    operationName = "Multiplicación";
                    break;
                default:
                    operationName = "Opcion Invalida";
                    Console.WriteLine("Opción Invalida");
                    return;
            }
            Console.Clear();
            Console.WriteLine("Usted Selecciono : " + operationName.ToUpper());

            Console.Write("Ingrese primer número: ");
            if (!double.TryParse(Console.ReadLine(), out double numberOne))
            {
                Console.WriteLine("No es un número, intente de nuevo");
                return;
            }

            Console.Write("Ingrese el segundo número: ");
            if (!double.TryParse(Console.ReadLine(), out double numberTwo))
            {
                Console.WriteLine("No es un número, intente de nuevo");
                return;
            }

            Console.Clear();

            string opcion = "";
            string salida = "";
            double resultado = 0;

            switch (operation)
            {
                case "1":
                    opcion = "Suma";
                    salida = "+";
                    resultado = numberOne + numberTwo;
                    break;
                case "2":
                    opcion = "Resta";
                    salida = "-";
                    resultado = numberOne - numberTwo;
                    break;
                case "3":
                    opcion = "División";
                    salida = "/";
                    if (numberTwo == 0)
                    {
                        Console.WriteLine("No se puede dividir entre cero, intente de nuevo");
                        return;
                    }
                    resultado = numberOne / numberTwo;
                    break;
                case "4":
                    opcion = "Multiplicación";
                    salida = "*";
                    resultado = numberOne * numberTwo;
                    break;
            }

            Console.WriteLine($"La {opcion} de {numberOne} {salida} {numberTwo} = {resultado}");
            Console.ReadKey();
        }
    }
}
