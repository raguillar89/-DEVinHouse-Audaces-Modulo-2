using Exercicio1ao10.Interface;

namespace Exercicio1ao10.Service
{
    public class MenuService
    {
        private readonly IClientService cs = new ClientService();
        public void ExibirMenu()
        {
            Console.WriteLine("Bem-vindo ao Menu \nQual das opções deseja? \n1. Abrir Conta \n2. Consultar Conta \n3. Listar Todas as Contas \n4. Sair\n");
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    cs.CriarConta();
                    break;

                case 2:
                    Console.Write("\nDigite o nome que deseja buscar: ");
                    cs.SearchClient(Console.ReadLine());
                    break;

                case 3:
                    cs.ExibirClientes();
                    break;

                case 4:
                    Console.Write("Tem certeza que quer sair (s/n)?");
                    string op = Console.ReadLine();

                    if (op == "n" || op == "N")
                    {
                        break;
                    }
                    return;

                default:
                    Console.WriteLine("Erro, opção inválida!");
                    Console.WriteLine();
                    break;
            }
            Console.WriteLine("\n");
            ExibirMenu();
        }
    }
}
