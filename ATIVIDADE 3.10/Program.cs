// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        // Entrada dos três valores
        Console.Write("Digite o primeiro valor: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o segundo valor: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o terceiro valor: ");
        double c = Convert.ToDouble(Console.ReadLine());

        // Cálculo das médias
        double mediaAritmetica = (a + b + c) / 3;
        double mediaHarmonica = 3 / ((1 / a) + (1 / b) + (1 / c));
        double mediaGeometrica = Math.Pow(a * b * c, 1.0 / 3);

        // Saída dos resultados
        Console.WriteLine($"\nMédia Aritmética: {mediaAritmetica:F2}");
        Console.WriteLine($"Média Harmônica: {mediaHarmonica:F2}");
        Console.WriteLine($"Média Geométrica: {mediaGeometrica:F2}");
    }
}

