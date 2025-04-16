// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        // Solicita o preço do produto ao usuário
        Console.Write("Informe o valor do produto: ");
        double preco = Convert.ToDouble(Console.ReadLine());

        // Calcula o novo valor com acréscimo de 10%
        double novoPreco = preco * 1.10;

        // Exibe o novo valor do produto
        Console.WriteLine($"Novo valor do produto: {novoPreco:F2}");
    }
}
