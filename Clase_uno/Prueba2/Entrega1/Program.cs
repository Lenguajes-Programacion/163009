using System;

namespace Entrega1
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona op = new Persona();
            int Opcion;
            Console.WriteLine("Bienvenido a las entregas de Big Yoshi... Por favor escoge una entrega \n");
            Console.WriteLine("1° Arreglo con Nombre \n2° Calculadora");
            Opcion = Int32.Parse(Console.ReadLine());
            do
            {
                switch (Opcion)
                {
                    case 1:
                        op.Personas();
                        break;
                    case 2:
                        break;
                    default:
                        break;
                }

            } while (Opcion != 3);
        }
    }
}
