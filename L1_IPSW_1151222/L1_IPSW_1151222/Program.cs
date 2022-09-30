using System;

namespace L1_IPSW_1151222
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese su nombre : ");
            string nombre = Console.ReadLine();

            Console.WriteLine("Hola Mundo");
            Console.WriteLine("Soy " + nombre );

            Console.Write("Hola Mundo ");
            Console.Write("Soy " + nombre);

            Console.ReadKey();
        }   
    }
}
