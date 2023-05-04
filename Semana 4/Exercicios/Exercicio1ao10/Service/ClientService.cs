using Exercicio1ao10.Interface;
using Exercicio1ao10.Model;

namespace Exercicio1ao10.Service
{
    class ClientService : IClientService
    {
        List<Clientes> clientes = new List<Clientes>();


        public void CriarConta()
        {      
            Inicio:
            Console.WriteLine("Qual tipo de conta deseja criar? \n1. Pessoa Física \n2. Pessoa Jurídica\n");
            int option = int.Parse(Console.ReadLine());

            if (option == 1)
            {
                CriarContaPF();
            }
            else if (option == 2)
            {
                CriarContaPJ();
            }
            else
            {
                Console.WriteLine("\nOpção inválida.\n");
                goto Inicio;
            }
        }

        public void CriarContaPF()
        {
            var pessoaFisica = new PessoaFisica();

            Console.Write("\nInsira o número da conta: ");
            int accountNumber;

            while (!int.TryParse(Console.ReadLine(), out accountNumber))
            {
                Console.WriteLine("Número de conta inválido, digite um número válido.");
            }
            pessoaFisica.AccountNumber = accountNumber;

            pessoaFisica.Balance = 0;

            pessoaFisica.ClientType = "Pessoa Física";

            Console.Write("\nInsira o nome do cliente: ");
            pessoaFisica.Name = Console.ReadLine();

            Console.Write("Insira o CPF do cliente: ");
            pessoaFisica.Cpf = Console.ReadLine();

            Console.Write("Insira a idade do cliente: ");
            pessoaFisica.Age = int.Parse(Console.ReadLine());

            Console.Write("Insira o endereço do cliente: ");
            pessoaFisica.Address = Console.ReadLine();

            Console.Write("Insira o telefone do cliente: ");
            pessoaFisica.PhoneNumber = Console.ReadLine();

            clientes.Add(pessoaFisica);
        }

        public void CriarContaPJ()
        {
            var pessoaJuridica = new PessoaJuridica();

            Console.Write("\nInsira o número da conta: ");
            int accountNumber;

            while (!int.TryParse(Console.ReadLine(), out accountNumber))
            {
                Console.WriteLine("Número de conta inválido, digite um número válido.");
            }
            pessoaJuridica.AccountNumber = accountNumber;

            pessoaJuridica.Balance = 0;

            pessoaJuridica.ClientType = "Pessoa Jurídica";

            Console.Write("\nInsira o nome da empresa: ");
            pessoaJuridica.Name = Console.ReadLine();

            Console.Write("Insira o CNPJ da empresa: ");
            pessoaJuridica.Cnpj = Console.ReadLine();

            Console.Write("Insira o endereço da empresa: ");
            pessoaJuridica.Address = Console.ReadLine();

            Console.Write("Insira o telefone da empresa: ");
            pessoaJuridica.PhoneNumber = Console.ReadLine();

            clientes.Add(pessoaJuridica);
        }

        public void SearchClient(string name)
        {                        
            var search = clientes.Where(x => x.Name == name);
            foreach (var cliente in search)
            {
                Console.WriteLine(cliente.ToString());
            }
        }

        public void ExibirClientes()
        {
            foreach (var cliente in clientes)
            {
                Console.WriteLine(cliente.ToString());
            }
            Console.WriteLine();
        }
    }
}
