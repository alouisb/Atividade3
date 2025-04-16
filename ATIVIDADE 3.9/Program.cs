// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        // Entrada: número total de segundos
        Console.Write("Digite a quantidade de segundos: ");
        int totalSegundos = Convert.ToInt32(Console.ReadLine());

        // Cálculos
        int horas = totalSegundos / 3600;
        int minutos = (totalSegundos % 3600) / 60;
        int segundos = totalSegundos % 60;

        // Saída formatada
        Console.WriteLine($"\nEquivalente a: {horas}h {minutos}min {segundos}s");
    }
}

