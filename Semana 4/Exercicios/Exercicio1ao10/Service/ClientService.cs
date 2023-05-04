using Exercicio1ao10.Interface;
using Exercicio1ao10.Model;

namespace Exercicio1ao10.Service
{
    class ClientService : IClientService
    {
        List<PessoaFisica> pf = new List<PessoaFisica>();
        List<PessoaJuridica> pj = new List<PessoaJuridica>();
        private readonly PessoaFisicaService pfService = new PessoaFisicaService();
        private readonly PessoaJuridicaService pjService = new PessoaJuridicaService();

        public void CriarConta()
        {      
            Inicio:
            Console.WriteLine("Qual tipo de conta deseja criar? \n1. Pessoa Física \n2. Pessoa Jurídica\n");
            int option = int.Parse(Console.ReadLine());

            if (option == 1)
            {
                pfService.CriarContaPF();
            }
            else if (option == 2)
            {
                pjService.CriarContaPJ();
            }
            else
            {
                Console.WriteLine("\nOpção inválida.\n");
                goto Inicio;
            }
        }

        public void SearchClient(string name)
        {
            Console.WriteLine("\nEscolha uma das opções: \n1. Pessoa Física \n2. Pessoa Jurídica");
            int option = int.Parse(Console.ReadLine());

            if (option == 1)
            {
                Console.Write("\nDigite o nome que deseja buscar: ");
                var filtro = pf.Where(x => x.Name == name);
                foreach (var pessoa in filtro)
                {
                    Console.WriteLine(pessoa.ToString());
                }
            }
            else
            {
                Console.Write("\nDigite o nome que deseja buscar: ");
                var filtro = pj.Where(x => x.Name == name);
                foreach (var pessoa in filtro)
                {
                    Console.WriteLine(pessoa.ToString());
                }
            }
        }

        public void ExibirClientes()
        {
            foreach (var pessoaFisica in pf)
            {
                Console.WriteLine("\nCliente: " + pessoaFisica.Name +
                                  "\nTipo de Conta: " + pessoaFisica.ClientType +
                                  "\nNúmero da Conta: " + pessoaFisica.AccountNumber +
                                  "\nIdade: " + pessoaFisica.Age +
                                  "\nCPF: " + pessoaFisica.Cpf +
                                  "\nEndereço: " + pessoaFisica.Address +
                                  "\nTelefone: " + pessoaFisica.PhoneNumber +
                                  "\nSaldo: R$" + pessoaFisica.Balance);
            }
            Console.WriteLine();

            foreach (var pessoaJuridica in pj)
            {
                Console.WriteLine("\nNome da Empresa: " + pessoaJuridica.Name +
                                  "\nTipo de Conta: " + pessoaJuridica.ClientType +
                                  "\nNúmero da Conta: " + pessoaJuridica.AccountNumber +
                                  "\nCPF: " + pessoaJuridica.Cnpj +
                                  "\nEndereço: " + pessoaJuridica.Address +
                                  "\nTelefone: " + pessoaJuridica.PhoneNumber +
                                  "\nSaldo: R$" + pessoaJuridica.Balance);
            }
            Console.WriteLine();
        }
    }
}
