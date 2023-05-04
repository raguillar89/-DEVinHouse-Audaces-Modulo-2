using Exercicio1ao10.Model;

namespace Exercicio1ao10.Service
{
    public class PessoaJuridicaService
    {
        List<PessoaJuridica> pj = new List<PessoaJuridica>();

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

            pj.Add(pessoaJuridica);
        }
    }
}
