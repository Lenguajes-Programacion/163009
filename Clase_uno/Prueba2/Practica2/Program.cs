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
        static void Calcu()
        {
            float NumeroUno;
            float NumeroDos;
            float Res = 0;
            int Principal;
            bool op;
            op = false;
            float ResDos = 0;
            do
            {
                Console.WriteLine("Bienvenido a la calculadora B.I.G  Y.O.S.H.I!");
                Console.WriteLine("1° Suma" + "\n" + "2° Resta" + "\n" + "3° Multiplicacion" + "\n" + "4° Division" + "\n" + "5° Memoria" + "\n" + "6° Salir");
                Principal = Int32.Parse(Console.ReadLine());
                    switch (Principal)
                    {
                        case 1:
                        if (op == true)
                        {
                            Console.WriteLine("Numero a sumar con el resultado anterior: ");
                            NumeroDos = Int32.Parse(Console.ReadLine());
                            ResDos = Res + NumeroDos;
                            Res = ResDos;
                        }
                        else
                        {
                            Console.WriteLine("¿Que quieres sumar Lmao? \n");
                            Console.WriteLine("Primer Numero: ");
                            NumeroUno = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Segundo Numero: ");
                            NumeroDos = Int32.Parse(Console.ReadLine());
                            Res = NumeroUno + NumeroDos;
                            op = true;
                        }
                        Console.WriteLine("Su resultado es: " + Res);
                        Console.WriteLine("\n");
                        break;
                    case 2:
                        if(op == true)
                        {
                            Console.WriteLine("Numero a restar con el resultado anterior: ");
                            NumeroDos = Int32.Parse(Console.ReadLine());
                            ResDos = Res - NumeroDos;
                            Res = ResDos;
                        }
                        else
                        {
                            Console.WriteLine("Es una Resta Lmao");
                            Console.WriteLine("Primer Numero: ");
                            NumeroUno = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Segundo Numero: ");
                            NumeroDos = Int32.Parse(Console.ReadLine());
                            Res = NumeroUno - NumeroDos;
                            op = true;
                        }
                        Console.WriteLine("Su resultado es: " + Res);
                        Console.WriteLine("\n");
                        break;
                    case 3:
                        if(op == true)
                        {
                            Console.WriteLine("Numero a multiplicar con el resultado anterior: ");
                            NumeroDos = Int32.Parse(Console.ReadLine());
                            ResDos = Res * NumeroDos;
                            Res = ResDos;
                        }
                        else
                        {
                            Console.WriteLine("Es una Multiplicacion Lmao");
                            Console.WriteLine("Primer Numero: ");
                            NumeroUno = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Segundo Numero: ");
                            NumeroDos = Int32.Parse(Console.ReadLine());
                            Res = NumeroUno * NumeroDos;
                            op = true;
                        }
                        Console.WriteLine("Su resultado es: " + Res);
                        Console.WriteLine("\n");
                        break;
                    case 4:
                        if(op == true)
                        {
                            Console.WriteLine("Numero a dividir con el resultado anterior: ");
                            NumeroDos = Int32.Parse(Console.ReadLine());
                            ResDos = Res / NumeroDos;
                            Res = ResDos;
                        }
                        else
                        {
                            Console.WriteLine("Es una Division Lmao");
                            Console.WriteLine("Primer Numero: ");
                            NumeroUno = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Segundo Numero: ");
                            NumeroDos = Int32.Parse(Console.ReadLine());
                            Res = NumeroUno / NumeroDos;
                            op = true;
                        }
                        Console.WriteLine("Su resultado es: " + Res);
                        Console.WriteLine("\n");
                        break;
                    case 5:
                        Memoria memo = new Memoria();
                        memo.Bidimencional();
                        Console.WriteLine("\n");
                        break;
                    case 6:
                        Console.WriteLine("Hasta la Proxima asdfghjkl!!!");
                        Console.WriteLine("\n");
                        break;
                    default:
                        Console.WriteLine("Los argumentos no tienen sentido Lmao");
                        Console.WriteLine("\n");
                        break;
                }
            } while (Principal != 6);
            Console.ReadKey();
        }
    }
}
