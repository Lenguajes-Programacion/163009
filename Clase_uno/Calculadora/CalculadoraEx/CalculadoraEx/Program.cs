using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraEx
{
    class EpicCalculadora
    {
        static void Main(string[] args)
        {
            NewFunciones Extra = new NewFunciones();
            float NumeroUno = 0;
            float NumeroDos = 0;
            float Res = 0;
            int Principal;
            do
            {
                Console.WriteLine("Bienvenido a la calculadora B.I.G  Y.O.S.H.I!");
                Console.WriteLine("1° Suma" + "\n" + "2° Resta" + "\n" + "3° Multiplicacion" + "\n" + "4° Division" + "\n" + "5° -------" + "\n6° Salir");
                Principal = Int32.Parse(Console.ReadLine());
                switch (Principal)
                {
                    case 1:
                        Console.WriteLine("¿Que quieres sumar Lmao? \n");
                        Console.WriteLine("Primer Numero: ");
                        NumeroUno = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Segundo Numero: ");
                        NumeroDos = Int32.Parse(Console.ReadLine());
                        Res = Funciones.Suma(NumeroUno, NumeroDos);
                        Console.WriteLine("Su resultado es: " + Res);
                        break;
                    case 2:
                        Console.WriteLine("Es una Resta Lmao");
                        Console.WriteLine("Primer Numero: ");
                        NumeroUno = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Segundo Numero: ");
                        NumeroDos = Int32.Parse(Console.ReadLine());
                        Res = Funciones.Resta(NumeroUno, NumeroDos);
                        Console.WriteLine("Su resultado es: " + Res);
                        break;
                    case 3:
                        Console.WriteLine("Es una Multiplicacion Lmao");
                        Console.WriteLine("Primer Numero: ");
                        NumeroUno = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Segundo Numero: ");
                        NumeroDos = Int32.Parse(Console.ReadLine());
                        Res = Funciones.Multuiplicacion(NumeroUno, NumeroDos);
                        Console.WriteLine("Su resultado es: " + Res);
                        break;
                    case 4:
                        Console.WriteLine("Es una Division Lmao");
                        Console.WriteLine("Primer Numero: ");
                        NumeroUno = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Segundo Numero: ");
                        NumeroDos = Int32.Parse(Console.ReadLine());
                        Res = Funciones.Divison(NumeroUno, NumeroDos);
                        Console.WriteLine("Su resultado es: " + Res);
                        break;
                    case 5:
                        Console.WriteLine("Que numero quieres potenciar y por cuanto Lmao");
                        Console.WriteLine("Primer Numero: ");
                        NumeroUno = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Segundo Numero: ");
                        NumeroDos = Int32.Parse(Console.ReadLine());
                        Extra.Potencia(NumeroUno, NumeroDos);
                        Console.WriteLine("\n");
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("Hasta la Proxima asdfghjkl!!!");
                        //Principal = Console.Read();
                        Console.WriteLine("\n");
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Los argumentos no tienen sentido Lmao");
                        Console.WriteLine("\n");
                        break;
                }
            } while (Principal != 6);
        }
    }
    class Funciones
    {
        public float NumeroUno;
        public float NumeroDos;

        public static float Suma(float NumeroUno, float NumeroDos)
        {
            float Res = 0;
            Res = NumeroUno + NumeroDos;
            return Res;
        }
        public static float Resta(float NumeroUno, float NumeroDos)
        {
            float Res = 0;
            Res = NumeroUno - NumeroDos;
            return Res;
        }

        public static float Multuiplicacion(float NumeroUno, float NumeroDos)
        {
            float Res = 0;
            Res = NumeroUno * NumeroDos;
            return Res;
        }

        public static float Divison(float NumeroUno, float NumeroDos)
        {
            float Res = 0;
            Res = NumeroUno / NumeroDos;
            return Res;
        }
    }

    class NewFunciones : Funciones
    {
        public void Potencia(float NumeroUno, float NumeroDos)
        {
            double Cuadrado = Math.Pow(NumeroUno, NumeroDos);
            Console.WriteLine("Su numero {0} elevado por {1} es {2}", NumeroUno, NumeroDos, Cuadrado);
        }
    }
}
