using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/* . Implementa en un programa un menú donde cada opción sea una función
distinta. Por ejemplo: “Mostrar fecha actual”, “Mostrar un saludo”, etc.

*/

namespace RubyPractics
{
    public class opciones()
    {
        public void menu()
        {
            int opcion = 0;
            do
            {
                Console.WriteLine("==== MENÚ DE OPCIONES ====");
                Console.WriteLine("1. Mostrar Fecha actual");
                Console.WriteLine("2. Mostrar Saludo");
                Console.WriteLine("3. Hora Actual ");
                Console.WriteLine("4. Despidete >:D ");

                string input = Console.ReadLine();

                if (int.TryParse(input, out opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            MostrarFechaActual();
                            break;

                        case 2:
                            MostrarSaludo();
                            break;
                        case 3:
                            MostrarHoraActual();
                            break;

                        case 4:
                            Salida();
                            break;
                        default:

                            Console.WriteLine("No existe esa opcion intente de nuevo");

                            break;
                    }
                    Console.WriteLine("");
                    Console.WriteLine("Gracias ..Ya bye. \n");
                    Console.ReadKey();
                }
            } while (opcion != 4);
        }

        static void MostrarFechaActual()
        {
            Console.WriteLine("La fecha es actual es: " + DateTime.Today.ToString("dd/mm/yyyy"));
        }

        static void MostrarSaludo()
        {
            Console.WriteLine("Saludando... ");
        }

        static void MostrarHoraActual()
        {
            Console.WriteLine("La hora actual es :" + DateTime.Now.ToString("HH:mm:ss"));
        }

        static void Salida()
        {
            Console.WriteLine("Chaito puee! xd");
        }
    }
}
