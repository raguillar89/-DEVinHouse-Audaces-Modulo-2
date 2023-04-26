using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    class ContaBancaria : Banco
    {
        private string AccountNumber;
        private Cliente Cliente;

        public ContaBancaria(string accountNumber, Cliente cliente)
        {
            AccountNumber = accountNumber;
            Cliente = cliente;
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Número da Conta: {AccountNumber}, Nome do Cliente: {Cliente.Nome}, CPF do Cliente: {Cliente.Cpf}, Saldo: R${Saldo}");
        }
    }
}
