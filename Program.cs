// See https://aka.ms/new-console-template for more information

using System;

class Programa
{
    static void Main()
    {
        Console.WriteLine("Por favor ingrese el primer número:");
        double primerNumero = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Por favor ingrese el segundo número:");
        double segundoNumero = Convert.ToDouble(Console.ReadLine());

        double resultado = CalcularDiferencia(primerNumero, segundoNumero);
        Console.WriteLine($"El resultado es: {resultado}");
    }

    static double CalcularDiferencia(double num1, double num2)
    {
        double diferencia = Math.Abs(num1 - num2);
        if (num1 > num2)
        {
            return diferencia * 2;
        }
        return diferencia;
    }
}


