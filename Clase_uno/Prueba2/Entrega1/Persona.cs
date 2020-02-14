using System;
using System.Collections.Generic;
using System.Text;

namespace Entrega1
{
    class Persona
    {
        public void Personas()
        {
            string Nombre = "Big";
            do
            {
                Console.WriteLine("Say your name...");
                Nombre = Console.ReadLine();
                if (Nombre == "Big")
                {
                    Console.WriteLine($"Hello " + Nombre);
                    Console.WriteLine("\n");
                }
                else
                {
                    Console.WriteLine($"GTFO " + Nombre);
                    Console.WriteLine("\n");
                }
            } while (Nombre != "Big");
            Console.ReadKey();
        }
    }
}
