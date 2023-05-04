using Exercicio1ao10.Model;

namespace Exercicio1ao10.Service
{
    public class PessoaFisicaService
    {
        List<PessoaFisica> pf = new List<PessoaFisica>();

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

            pf.Add(pessoaFisica);
        }
    }
}
