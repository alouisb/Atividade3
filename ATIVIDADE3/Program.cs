using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATIVIDADE3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // ATVIDADE 3 : PAGAMENTO DE COMISSÃO
            // COMISSÃO DE 55 SOBRE O TOTAL DE VENDAS

            // CRIANDO VARIÁVEIS    

            string vendedor;
            string novoCodigo;

            int codigo1 = 123;
            int codigo2 = 234;
            int codigo3 = 345;
            int identificacaoCodigo;

            int preco1 = 100;
            int preco2 = 250;
            int preco3 = 75;

            int quantidade;


            // IDENTIFICAÇÃO DO VENDEDOR

            Console.WriteLine("Digite o nome do vendedor: ");
            vendedor = Console.ReadLine();

            // CÓDIGO DA PEÇA VENDIDA E PREÇO

            Console.WriteLine("Código das Peças: ");
            Console.WriteLine("AIRMAX: " + codigo1);
            Console.WriteLine("CAMISA: " + codigo2);
            Console.WriteLine("BERMUDA: " + codigo3);


            // PREÇO DE CADA PEÇA 

            Console.WriteLine("\n");
            Console.WriteLine("Preço de cada Peça: ");
            Console.WriteLine("O valor do AIRMAX é: R$" + preco1);
            Console.WriteLine("O valor da CAMISA é: R$" + preco2);
            Console.WriteLine("O valor da Bermuda é: R$" + preco3);

            Console.WriteLine("\n");
            Console.WriteLine("Digite o código da peça vendida: ");
            identificacaoCodigo = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < identificacaoCodigo; i++)
            {
                if (identificacaoCodigo == codigo1 || identificacaoCodigo == codigo2 || identificacaoCodigo == codigo3)
                {
                    Console.WriteLine("Você deseja adicionar mais alguma peça? (S/N) ");
                    novoCodigo = Console.ReadLine();

                    if (novoCodigo == "S")
                    {
                        Console.WriteLine("Adicione o código da proxima  peça: ");
                        identificacaoCodigo = Convert.ToInt32(Console.ReadLine());

                    }
                    else
                    {

                        Console.WriteLine("Fim da venda");
                        break;
                    }
                }

                // Valor vendido

                Console.WriteLine("\n");
                Console.WriteLine (

                codigo1 = preco1;
                codigo2 = preco2;
                codigo3 = preco3;

                Console.WriteLine("A quantidade vendida foi: R$" + );
            }
                      
            Console.ReadKey();  
        }
    }
}
