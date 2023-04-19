using System;

namespace Exercicio3_10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Proprietario> proprietarios = new List<Proprietario>();
            proprietarios.Add(new Proprietario() { nome = "Rinul", cpf = "876.907.980-39", telefone = "(11)11111-1111" });
            proprietarios.Add(new Proprietario() { nome = "Hapoi", cpf = "479.861.520-01", telefone = "(22)22222-2222" });
            proprietarios.Add(new Proprietario() { nome = "Zikiu", cpf = "094.426.760-24", telefone = "(33)33333-3333" });

            List<Carro> carros = new List<Carro>();
            carros.Add(new Carro() { marca = "Ford", modelo = "Fiesta", placa = "AUD2486", cor = "Preto", proprietario = "Rinul" });
            carros.Add(new Carro() { marca = "Ford", modelo = "Focus", placa = "UAD8642", cor = "Vermelho", proprietario = "Hapoi" });
            carros.Add(new Carro() { marca = "Ford", modelo = "Ranger", placa = "ADU7592", cor = "Cinza", proprietario = "Zikiu" });

            Inicio:

            Console.WriteLine("________________________________");
            Console.WriteLine("|              MENU            |");
            Console.Write("|______________________________|");
            Console.Write("\n|1: Listagem de Proprietários  |\n|2: Listagem de Carros         |\n|3: Cadastrar Novo Proprietário|\n|4: Cadastrar Novo Carro       |\n|5: Sair                       |\n");
            Console.WriteLine("|______________________________|\n");
            Console.Write("Escolha uma das opções do Menu: ");
            
            int op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    foreach (var prop in proprietarios)
                    {
                        Console.WriteLine("\nProprietário: " + prop.nome +
                                          "\nCPF: " + prop.cpf +
                                          "\nTelefone: " + prop.telefone);
                    }
                    Console.WriteLine();
                    goto Inicio;

                case 2:
                    foreach (var carro in carros)
                    {
                        Console.WriteLine("\nMarca: " + carro.marca +
                                          "\nModelo: " + carro.modelo +
                                          "\nPlaca: " + carro.placa +
                                          "\nCor: " + carro.cor +
                                          "\nProprietario: " + carro.proprietario);
                    }
                    Console.WriteLine();
                    goto Inicio;

                case 3:
                    Console.Write("Digite o nome do proprietário: ");
                    string nome = Console.ReadLine();

                    Console.Write("Digite o cpf do proprietário: ");
                    string cpf = Console.ReadLine();

                    Console.Write("Digite a telefone do proprietário: ");
                    string telefone = Console.ReadLine();

                    proprietarios.Add(new Proprietario() { nome = nome, cpf = cpf, telefone = telefone });

                    Console.WriteLine();
                    goto Inicio;

                case 4:
                    Console.Write("Digite a marca do veículo: ");
                    string marca = Console.ReadLine();

                    Console.Write("Digite o modelo do veículo: ");
                    string modelo = Console.ReadLine();

                    Console.Write("Digite a placa do veículo: ");
                    string placa = Console.ReadLine();

                    Console.Write("Digite a cor do veículo: ");
                    string cor = Console.ReadLine();

                    Console.Write("Escolha e digite o nome proprietário na listagem abaixo: \n");
                    for(int i = 0; i < proprietarios.Count; i++)
                    {
                        Console.Write(i + ": " + proprietarios[i].nome + "\n");
                    }
                    Console.WriteLine();
                    string proprietario = Console.ReadLine();

                    carros.Add(new Carro() { marca = marca, modelo = modelo, placa = placa, cor = cor, proprietario = proprietario });

                    Console.WriteLine();
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