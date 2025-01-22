using System;

namespace Others
{
    public class InputAge
    {
        public void CheckAge()
        {
            Console.WriteLine("Ingrese su edad: ");

            if (int.TryParse(Console.ReadLine(), out int age)) // Ojo numeros enteros
            {
                if (age < 0)
                {
                    Console.WriteLine("Edad inválida: {0}.", age);
                }
                else if (age > 120)
                {
                    Console.WriteLine("Usted ya no está vivo... Edad ingresada: {0}.", age);
                }
                else if (age < 18)
                {
                    Console.WriteLine("Usted es menor de edad: {0} años.", age);
                }
                else
                {
                    Console.WriteLine("Usted es mayor de edad: {0} años.", age);
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, ingrese un número entero válido.");
            }
        }
    }
}
