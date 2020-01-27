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
            string Nombre = "Big Yoshi";
            Console.WriteLine($"Hello {args[0]}");

            if (Nombre == "Big Yoshi")
	{
                Console.WriteLine("Hola Big Yoshi");
	}
            else(Nombre != "Big Yoshi");
	{
                Console.WriteLine("GTFO");
	}
            Console.ReadKey();
        }
    }
}
