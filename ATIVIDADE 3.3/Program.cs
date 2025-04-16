// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        // Solicita a temperatura em Fahrenheit
        Console.Write("Informe a temperatura em graus Fahrenheit: ");
        double fahrenheit = Convert.ToDouble(Console.ReadLine());

        // Converte para graus Celsius
        double celsius = (fahrenheit - 32) / 1.8;

        // Exibe o resultado
        Console.WriteLine($"Temperatura em graus Celsius: {celsius:F2}");
    }
}