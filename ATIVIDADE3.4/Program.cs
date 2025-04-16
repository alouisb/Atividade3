// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        // Leitura dos dados da aplicação
        Console.Write("Informe o capital a ser aplicado (C): ");
        double capital = Convert.ToDouble(Console.ReadLine());

        Console.Write("Informe o prazo da aplicação em meses (n): ");
        int prazo = Convert.ToInt32(Console.ReadLine());

        Console.Write("Informe a taxa de juros mensal (em %): ");
        double taxaJuros = Convert.ToDouble(Console.ReadLine());

        // Converte a taxa percentual para decimal
        double taxaDecimal = taxaJuros / 100;

        // Cálculo do montante com juros compostos
        double montante = capital * Math.Pow(1 + taxaDecimal, prazo);

        // Exibe o resultado
        Console.WriteLine($"Montante a ser recebido: {montante:F2}");
    }
}