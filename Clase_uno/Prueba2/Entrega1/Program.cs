using System;

namespace Entrega1
{
    public class Program
    {
        /*
        private int Opcion;
        public int opcion
        {
            get { return Opcion; }
            set { Opcion = value; }
        }
        */
        static void Main(string[] args)
        {
            Persona op = new Persona();
            EpicCalculadora Lmao = new EpicCalculadora();
            int opcion;
            Console.WriteLine("Bienvenido a las entregas de Big Yoshi... Por favor escoge una entrega \n");
            Console.WriteLine("1° Arreglo con Nombre \n2° Calculadora");
            opcion = Int32.Parse(Console.ReadLine());
            do
            {
                switch (opcion)
                {
                    case 1:
                        op.Personas();
                        break;
                    case 2:
                        Lmao.PrincipalCal();
                        break;
                    default:
                        Console.WriteLine("Non non non non non");
                        break;
                }

            } while (opcion != 3);
        }
    }
}
