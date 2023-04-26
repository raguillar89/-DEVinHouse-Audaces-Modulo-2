using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5
{
    class Pessoa
    {
        private string _Nome;
        private int _Idade;

        public Pessoa(string nome, int idade)
        {
            _Nome = nome;
            _Idade = idade;
        }

        public int Idade
        {
            get { return _Idade; }
            set { _Idade = value; }
        }

        public void DefinirIdade()
        {
            if(_Idade > 0)
            {
                Console.WriteLine("Idade válida.");
            }
            else
            {
                Console.WriteLine("Idade inválida.");
            }
        }
    }
}
