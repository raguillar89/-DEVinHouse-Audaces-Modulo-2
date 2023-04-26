using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    class ContaBancaria
    {
        private double _Saldo = 0;
        private double _Taxa = 10;

        public double Saldo
        {
            get { return _Saldo; }
            private set { _Saldo = Saldo; }
        }

        public void Depositar(double valor)
        {
            _Saldo += valor;
            Console.WriteLine($"Depósito de R${valor}\nSaldo: R${_Saldo}");
        }

        public void Sacar(double valor)
        {
            valor += _Taxa;
            if(_Saldo - valor > 0)
            {
                _Saldo -= valor;
                Console.WriteLine($"Saque de R${valor}\nSaldo: R${_Saldo}");
            }
            else
            {
                Console.WriteLine("Valor maior que o saldo disponível.");
            }
        }
    }
}
