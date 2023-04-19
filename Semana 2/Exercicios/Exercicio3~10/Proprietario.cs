using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3_10
{
    public class Proprietario
    {
        public string nome { get; set; }
        public string cpf { get; set; }
        public string telefone { get; set; }

        public Proprietario() { }

        public Proprietario(string nome, string cpf, string telefone)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.telefone = telefone;
        }
    }
}
