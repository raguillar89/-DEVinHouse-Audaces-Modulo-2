using System.Drawing;
using System.Collections.Generic;

namespace Exercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria cb = new ContaBancaria();

            Inicio:

            Console.WriteLine("Escolha uma das opções: \n1 - Saldo Disponível \n2 - Extrato de Transações \n3 - Depositar \n4 - Sacar \n5 - Sair\n");
            int op = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (op)
            {
                case 1:
                    Console.WriteLine($"O saldo disponível é de R${cb.Saldo}\n");
                    goto Inicio;

                case 2:
                    Console.WriteLine("Extrato Bancário");
                    foreach (var item in cb.extrato)
                    {
                        Console.WriteLine(item);
                    }
                    Console.WriteLine();
                    goto Inicio;

                case 3:
                    Console.Write("Digite o valor que gostaria de depositar: R$");
                    double depositar = double.Parse(Console.ReadLine());
                    cb.Depositar(depositar);
                    Console.WriteLine();
                    goto Inicio;

                case 4:
                    Console.Write("Digite o valor que gostaria de sacar: R$");
                    double sacar = double.Parse(Console.ReadLine());
                    cb.Sacar(sacar);
                    goto Inicio;

                case 5:
                    Console.Write("Tem certeza que quer sair (s/n)?");
                    string opcao = Console.ReadLine();

                    if (opcao == "n" || opcao == "N")
                    {
                        goto Inicio;
                    }
                    break;

                default:
                    Console.WriteLine("Erro, opção inválida!");
                    Console.WriteLine();
                    goto Inicio;
            }
        }
    }
}