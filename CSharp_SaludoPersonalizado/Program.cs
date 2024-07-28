using System;

class Program
{
    static void Main()
    {
        Console.Write("Por favor, introduce tu nombre: ");
        string nombre = Console.ReadLine();

        if (nombre.Equals("Alejandro", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("Hola");
        }
        else
        {
            Console.WriteLine("No te conozco");
        }
    }
}
