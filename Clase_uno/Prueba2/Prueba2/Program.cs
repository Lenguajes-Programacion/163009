﻿using System;
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
    // && = Se cumple todo.
    // || = Es permisivo.
    // !false = true
}
