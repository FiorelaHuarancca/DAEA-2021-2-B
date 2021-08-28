using System;

namespace HolaMundo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola, ¿Cómo te llamas? ->");
            string nombre = Console.ReadLine();
            Console.WriteLine("mucho gusto en conocerte " + nombre + " ,yo soy Fiorela");
        }
    }
}
