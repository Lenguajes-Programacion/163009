using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaUno
{
    class Program
    {
        static void Main(string[] args)
        {
            string Nombre = "Big";
            Console.WriteLine("Say your name...");
            //Nombre = Console.ReadLine();
            if (args[0].Length > 0 || args[0] == Nombre)
            {
                Console.WriteLine($"Hello {args[0]}");
            }
            else
            {
                Console.WriteLine("GTFO");
            }
            Console.ReadKey();
        }
    }
    // && = Se cumple todo.
    // || = Es permisivo.
    // !false = true
}
