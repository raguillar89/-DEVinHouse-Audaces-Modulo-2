using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Pessoa
    {
        private string Nome { get; set; }
        protected int Idade { get; set; }
        public string Endereco { get; set; }

        public Pessoa() { }

        public Pessoa(string nome, int idade, string endereco)
        {
            Nome = nome;
            Idade = idade;
            Endereco = endereco;
        }                

        public void Saudacao()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos.");
        }
    }
}
