// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        // Entrada de dados
        Console.Write("Informe o total de veículos no estacionamento: ");
        int totalVeiculos = Convert.ToInt32(Console.ReadLine());

        Console.Write("Informe o total de rodas no estacionamento: ");
        int totalRodas = Convert.ToInt32(Console.ReadLine());

        // Cálculo baseado no sistema de equações
        int carros = (totalRodas - 2 * totalVeiculos) / 2;
        int motos = totalVeiculos - carros;

        // Verificação de solução válida
        if (carros >= 0 && motos >= 0 && (4 * carros + 2 * motos == totalRodas))
        {
            Console.WriteLine($"\nTotal de carros: {carros}");
            Console.WriteLine($"Total de motos: {motos}");
        }
        else
        {
            Console.WriteLine("\nOs dados informados são inválidos. Verifique se os valores estão corretos.");
        }
    }
}
