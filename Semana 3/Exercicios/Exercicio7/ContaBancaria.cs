using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio7
{
    class ContaBancaria
    {
        private string _NumeroDaConta;
        private double _Saldo;
        private double _SaldoMaximo = 100000;
        private double _Taxa = 10;

        public ContaBancaria(string numeroDaConta, double saldo)
        {
            _NumeroDaConta = numeroDaConta;
            _Saldo = saldo;
        }

        public string NumeroDaConta
        {
            get { return _NumeroDaConta; }
            set { _NumeroDaConta = value; }
        }

        public double Saldo
        {
            get { return _Saldo; }
            set { _Saldo = value; }
        }

        public void Depositar(double valor)
        {
            if(valor > 0 && valor < valor + Saldo)
            {
                Saldo += valor;
                Console.WriteLine($"Valor Depositado: R${valor} \nSaldo Atual: R${Saldo}\n");
            }
            else
            {
                Console.WriteLine("Valor a ser depositado tem que ser maior que zero e o saldo máximo da conta não pode ser ultrapassado.");
            }
        }

        public void Sacar(double valor)
        {
            if(valor > 0 && valor > valor - Saldo)
            {
                valor += _Taxa;
                Saldo -= valor;
                Console.WriteLine($"Valor Sacado + Taxa de Saque (R$10): R${valor} \nSaldo Atual: R${Saldo}\n");
            }
            else
            {
                Console.WriteLine("Valor a ser sacado tem que ser maior que zero e menor que o saldo máximo da conta.");
            }
        }
    }
}
