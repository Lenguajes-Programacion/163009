/*
 Nombre: Jesús Eli Roemro Díaz.
 Materia: Lenguajes de Programacion I
 Practica: Calculadora
 */
using System;

namespace Practica2
{
    class Program
    {
        static void Main(string[] args)
        {
            float NumeroUno;
            float NumeroDos;
            float Res;
            int Principal;
            do
            {
                Console.WriteLine("Bienvenido a la calculadora B.I.G  Y.O.S.H.I!");
                Console.WriteLine("1° Suma" + "\n" + "2° Resta" + "\n" + "3° Multiplicacion" + "\n" + "4° Division" + "\n" + "5° Salir" + "\n");
                Principal = Int32.Parse(Console.ReadLine());
                switch (Principal)
                {
                    case 1:
                        Console.WriteLine("¿Que quieres sumar Lmao? \n");
                        Console.WriteLine("Primer Numero: ");
                        NumeroUno = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Segundo Numero: ");
                        NumeroDos = Int32.Parse(Console.ReadLine());
                        Res = NumeroUno + NumeroDos;
                        Console.WriteLine("Su resultado es: " + Res);
                        Console.WriteLine("\n");
                        break;
                    case 2:
                        Console.WriteLine("Es una Resta Lmao");
                        Console.WriteLine("Primer Numero: ");
                        NumeroUno = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Segundo Numero: ");
                        NumeroDos = Int32.Parse(Console.ReadLine());
                        Res = NumeroUno - NumeroDos;
                        Console.WriteLine("Su resultado es: " + Res);
                        Console.WriteLine("\n");
                        break;
                    case 3:
                        Console.WriteLine("Es una Multiplicacion Lmao");
                        Console.WriteLine("Primer Numero: ");
                        NumeroUno = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Segundo Numero: ");
                        NumeroDos = Int32.Parse(Console.ReadLine());
                        Res = NumeroUno * NumeroDos;
                        Console.WriteLine("Su resultado es: " + Res);
                        Console.WriteLine("\n");
                        break;
                    case 4:
                        Console.WriteLine("Es una Division Lmao");
                        Console.WriteLine("Primer Numero: ");
                        NumeroUno = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Segundo Numero: ");
                        NumeroDos = Int32.Parse(Console.ReadLine());
                        Res = NumeroUno / NumeroDos;
                        Console.WriteLine("Su resultado es: " + Res);
                        Console.WriteLine("\n");
                        break;
                    case 5:
                        Console.WriteLine("Hasta la Proxima asdfghjkl!!!");
                        Console.WriteLine("\n");
                        break;
                    default:
                        Console.WriteLine("Los argumentos no tienen sentido Lmao");
                        Console.WriteLine("\n");
                        break;
                }
            } while (Principal != 5);
            Console.ReadKey();
        }
    }
}
