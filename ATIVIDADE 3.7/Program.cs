// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        // Entrada de dados
        Console.Write("Informe o salário fixo do vendedor: R$ ");
        double salarioFixo = Convert.ToDouble(Console.ReadLine());

        Console.Write("Informe o valor total das vendas no mês: R$ ");
        double totalVendas = Convert.ToDouble(Console.ReadLine());

        Console.Write("Informe o percentual de comissão sobre as vendas (%): ");
        double percentualComissao = Convert.ToDouble(Console.ReadLine());

        // Cálculo da comissão e do salário total
        double comissao = totalVendas * (percentualComissao / 100);
        double salarioTotal = salarioFixo + comissao;

        // Saída do resultado
        Console.WriteLine($"\nComissão sobre as vendas: R$ {comissao:F2}");
        Console.WriteLine($"Salário total do vendedor: R$ {salarioTotal:F2}");
    }
}

