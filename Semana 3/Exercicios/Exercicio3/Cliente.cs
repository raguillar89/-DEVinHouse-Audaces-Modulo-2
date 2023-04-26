using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    class Cliente
    {
        private string _Nome;
        private string _Cpf;

        public Cliente(string nome, string cpf)
        {
            _Nome = nome;
            _Cpf = cpf;
        }

        public string Nome
        {
            get { return _Nome; }
            set { _Nome = value; }
        }

        public string Cpf
        {
            get { return _Cpf; }
            set { _Cpf = value; }
        }
    }
}
