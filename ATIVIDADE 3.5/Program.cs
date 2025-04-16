// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        // Entrada de dados
        Console.Write("Informe o número de horas trabalhadas no mês: ");
        double horasTrabalhadas = Convert.ToDouble(Console.ReadLine());

        Console.Write("Informe o valor recebido por hora de trabalho: ");
        double valorHora = Convert.ToDouble(Console.ReadLine());

        Console.Write("Informe o valor do salário família por filho menor de 14 anos: ");
        double salarioFamiliaPorFilho = Convert.ToDouble(Console.ReadLine());

        Console.Write("Informe o número de filhos com menos de 14 anos: ");
        int numeroFilhos = Convert.ToInt32(Console.ReadLine());

        // Cálculos
        double salarioBase = horasTrabalhadas * valorHora;
        double salarioFamilia = salarioFamiliaPorFilho * numeroFilhos;
        double salarioBruto = salarioBase + salarioFamilia;

        // Saída
        Console.WriteLine($"\nSalário base: R$ {salarioBase:F2}");
        Console.WriteLine($"Salário família: R$ {salarioFamilia:F2}");
        Console.WriteLine($"Salário bruto total: R$ {salarioBruto:F2}");
    }
}

