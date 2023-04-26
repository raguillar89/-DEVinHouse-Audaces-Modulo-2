using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio10
{
    class ContaBancaria
    {
        private double _Saldo = 0;
        private double _Taxa = 10;

        public List<string> extrato = new List<string>();

        public double Saldo
        {
            get { return _Saldo; }
            set { _Saldo = value; }
        }

        public void Depositar(double valor)
        {
            _Saldo += valor;
            extrato.Add($"Depósito de R${valor}");
        }

        public void Sacar(double valor)
        {
            valor += _Taxa;
            if (_Saldo - valor > 0)
            {
                _Saldo -= valor;
                extrato.Add($"Saque de R${valor}");
            }
            else
            {
                Console.WriteLine("Valor maior que o saldo disponível.\n");
            }
        }
    }
}
