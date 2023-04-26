using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class ContaBancaria
    {
        private string _AccountNumber;
        private double _Saldo = 0;
        private double _Taxa = 10;

        public ContaBancaria(string accountNumber)
        {
            _AccountNumber = accountNumber;
        }

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
        }

        public void Sacar(double valor)
        {
            valor += _Taxa;
            _Saldo -= valor;
        }
    }
}
