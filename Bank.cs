using System;

namespace RubyPractics
{
    public class Bank
    {
        public void BankAccount()
        {
            double saldo = 5000;
            bool salir = false;

            while (!salir)
            {
                Console.WriteLine("1. Ver saldo");
                Console.WriteLine("2. Ingresar Dinero");
                Console.WriteLine("3. Retirar Dinero");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");

                string input = Console.ReadLine() ?? string.Empty;

                if (int.TryParse(input, out int opcion))
                {
                    if (opcion == 1)
                    {
                        Console.WriteLine($"Su saldo actual es: {saldo:F2}");
                    }
                    else if (opcion == 2)
                    {
                        Console.WriteLine("Ingrese monto a depositar:");
                        if (
                            double.TryParse(Console.ReadLine(), out double deposito)
                            && deposito > 0
                        )
                        {
                            saldo += deposito;
                            Console.WriteLine(
                                $"Usted depositó {deposito:F2}. Su saldo actual es {saldo:F2}"
                            );
                        }
                        else
                        {
                            Console.WriteLine(
                                "Monto inválido. Por favor, ingrese una cantidad válida."
                            );
                        }
                    }
                    else if (opcion == 3)
                    {
                        Console.WriteLine("Ingrese monto a retirar:");
                        if (double.TryParse(Console.ReadLine(), out double retirar) && retirar > 0)
                        {
                            if (retirar <= saldo)
                            {
                                saldo -= retirar;
                                Console.WriteLine(
                                    $"Usted retiró {retirar:F2}. Su saldo actual es {saldo:F2}"
                                );
                            }
                            else if (retirar > saldo)
                            {
                                Console.WriteLine("Saldo insuficiente. Intente de nuevo");
                            }
                            else
                            {
                                Console.WriteLine("Saldo insuficiente.");
                            }
                        }
                        else
                        {
                            Console.WriteLine(
                                "Monto inválido. Por favor, ingrese una cantidad válida."
                            );
                        }
                    }
                    else if (opcion == 4)
                    {
                        salir = true;
                        Console.WriteLine("Gracias por utilizar nuestros servicios.");
                    }
                    else
                    {
                        Console.WriteLine("Opción inválida. Intente de nuevo.");
                    }
                }
                else
                {
                    Console.WriteLine("Opción inválida. Intente de nuevo.");
                }

                Console.WriteLine("\nPresione cualquier tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
