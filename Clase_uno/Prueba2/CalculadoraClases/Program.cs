using System;

namespace CalculadoraClases
{
    class Program
    {
        public float NumeroUno;
        public float NumeroDos;
        public float Res;
        public bool op = false;
        public float ResDos = 0;

        Program()
        {

        }
        
        public float Suma()
        {
            if (op == true)
            {
                Console.WriteLine("Numero a sumar con el resultado anterior: ");
                NumeroDos = Int32.Parse(Console.ReadLine());
                ResDos = Res + NumeroDos;
                Res = ResDos;
                Console.Clear();
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
                Console.Clear();
            }
            Console.WriteLine("Su resultado es: " + Res);
            Console.WriteLine("\n");
            return Res;
        }
        public float Resta()
        {
            if (op == true)
            {
                Console.WriteLine("Numero a restar con el resultado anterior: ");
                NumeroDos = Int32.Parse(Console.ReadLine());
                ResDos = Res - NumeroDos;
                Res = ResDos;
                Console.Clear();
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
                Console.Clear();
            }
            Console.WriteLine("Su resultado es: " + Res);
            Console.WriteLine("\n");
            return Res;
        }

        public float Multuiplicacion()
        {
            if (op == true)
            {
                Console.WriteLine("Numero a multiplicar con el resultado anterior: ");
                NumeroDos = Int32.Parse(Console.ReadLine());
                ResDos = Res * NumeroDos;
                Res = ResDos;
                Console.Clear();
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
                Console.Clear();
            }
            Console.WriteLine("Su resultado es: " + Res);
            Console.WriteLine("\n");
            return Res;
        }

        public float Divison()
        {
            if (op == true)
            {
                Console.WriteLine("Numero a dividir con el resultado anterior: ");
                NumeroDos = Int32.Parse(Console.ReadLine());
                ResDos = Res / NumeroDos;
                Res = ResDos;
                Console.Clear();
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
                Console.Clear();
            }
            Console.WriteLine("Su resultado es: " + Res);
            Console.WriteLine("\n");
            return Res;
        }
        static void Main(string[] args)
        {
            Program Chungus = new Program();
           int Principal;
            do
            {
                Console.WriteLine("Bienvenido a la calculadora B.I.G  Y.O.S.H.I!");
                Console.WriteLine("1° Suma" + "\n" + "2° Resta" + "\n" + "3° Multiplicacion" + "\n" + "4° Division" + "\n" + "5° Salir" + "\n");
                Principal = Int32.Parse(Console.ReadLine());
                switch (Principal)
                {
                    case 1:
                        Chungus.Suma();
                        break;
                    case 2:
                        Chungus.Resta();
                        break;
                    case 3:
                        Chungus.Multuiplicacion();
                        break;
                    case 4:
                        Chungus.Divison();
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Hasta la Proxima asdfghjkl!!!");
                        Console.WriteLine("\n");
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Los argumentos no tienen sentido Lmao");
                        Console.WriteLine("\n");
                        break;
                }
            } while (Principal != 5);
            Console.ReadKey();
        }
    }
    
}
