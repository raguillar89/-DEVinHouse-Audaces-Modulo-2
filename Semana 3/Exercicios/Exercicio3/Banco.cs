using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    class Banco
    {
        private double _Saldo = 0;
        private double _Taxa = 10;

        public double Saldo
        {
            get
            {
                return _Saldo;
            }

            private set
            {
                _Saldo = value;
            }
        }

        public void Depositar(double valor)
        {
            _Saldo += valor;
            Console.WriteLine($"Depósito de R${_Saldo}\n");
        }

        public void Sacar(double valor)
        {
            valor += _Taxa;
            _Saldo -= valor;
            Console.WriteLine($"Saque de R${_Saldo}\n");
        }
    }
}
