// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        // Entrada de dados
        Console.Write("Digite o número (valor do logaritmando): ");
        double numero = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a base do logaritmo: ");
        double baseLog = Convert.ToDouble(Console.ReadLine());

        // Verifica se os valores são válidos para cálculo de logaritmo
        if (numero > 0 && baseLog > 0 && baseLog != 1)
        {
            // Cálculo do logaritmo
            double resultado = Math.Log(numero, baseLog);

            // Saída do resultado
            Console.WriteLine($"Logaritmo de {numero} na base {baseLog} é: {resultado:F4}");
        }
        else
        {
            Console.WriteLine("Erro: O número deve ser maior que zero e a base deve ser maior que zero e diferente de 1.");
        }
    }
}
