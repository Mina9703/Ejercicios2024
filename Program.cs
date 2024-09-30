// See https://aka.ms/new-console-template for more information
using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Números impares del 1 al 99:\n");

        for (int i = 1; i < 100; i += 2)
        {
            Console.WriteLine($"El número {i} es impar");
        }
    }
}
