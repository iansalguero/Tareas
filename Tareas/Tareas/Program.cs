
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tareas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mi segundo programa");
            Console.WriteLine();
            Console.WriteLine();
            string nombre, edad, carrera, carnet;
            Console.WriteLine("Ingrese su nombre:");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su edad");
            edad = Console.ReadLine();
            Console.WriteLine("Ingrese su carrera");
            carrera = Console.ReadLine();
            Console.WriteLine("Ingrese su carné");
            carnet = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Edad: "+edad);
            Console.WriteLine("Carrera: "+carrera);
            Console.WriteLine("Carné: "+carnet);
            Console.WriteLine();
            Console.WriteLine("Soy " + nombre + " tengo " + edad + " años y estudio la carrera de " + carrera +"." );
            Console.WriteLine("Mi numero de carné es " + carnet +".");
            Console.ReadKey();
        }
    }
}
