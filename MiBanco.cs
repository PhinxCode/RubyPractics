using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Others
{
    public class MiBanco
    {
        public static void Menu()
        {
            double saldo = 2000;
            bool salir = false;

            while (!salir)
            {
                Console.Clear();
                Console.WriteLine("Menú de opciones:");
                Console.WriteLine("1. Ver Saldo");
                Console.WriteLine("2. Ingresar Dinero");
                Console.WriteLine("3. Retirar Dinero");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");

                string? input = Console.ReadLine();

                if (int.TryParse(input, out int opcion))
                {
                    if (opcion == 1)
                    {
                        Console.WriteLine($"Su saldo actual es: {saldo}");
                    }
                    else if (opcion == 2)
                    {
                        Console.Write("Ingrese el monto a depositar: ");

                        if (
                            double.TryParse(Console.ReadLine(), out double deposito)
                            && deposito > 0
                        )
                        {
                            saldo += deposito;
                            Console.WriteLine(
                                $"Usted depositó: {deposito}. Su saldo actual es {saldo}"
                            );
                        }
                        else
                        {
                            Console.WriteLine("Cantidad invalida. Intente de nuevo.");
                        }
                    }
                    else if (opcion == 3)
                    {
                        Console.Write("Ingrese el monto a retirar: ");
                        if (double.TryParse(Console.ReadLine(), out double retirar) && retirar > 0)
                        {
                            if (retirar <= saldo)
                            {
                                saldo -= retirar;
                                Console.WriteLine(
                                    $"Usted retiró: {retirar}. Su saldo actual es {saldo}"
                                );
                            }
                            else
                            {
                                Console.WriteLine("Saldo insuficiente.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Cantidad inválida. Intente de nuevo.");
                        }
                    }
                    else if (opcion == 4)
                    {
                        Console.WriteLine("Gracias por usar nuestro servicio. ¡Hasta luego!");
                        salir = true;
                    }
                    else
                    {
                        Console.WriteLine("Opción inválida. Intente de nuevo.");
                    }
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Intente de nuevo.");
                }

                Console.WriteLine("\nPresione cualquier tecla para continuar...");
                Console.ReadKey();
            }
        }
    }
}

/*
Crea un programa que simule un menú de opciones simples (1. Ver Saldo,
2. Ingresar Dinero, 3. Retirar Dinero, 4. Salir) usando un bucle while que se
repita hasta que el usuario elija la opción “Salir”.
*/
