using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    class Metodos
    {
        public void NomeIdade(int idade, string nome)
        {
            if (idade < 18)
            {
                Console.WriteLine("O paciente " + nome + " é menor de idade.");
            }
            else if(idade > 18 && idade < 60)
            {
                Console.WriteLine("O paciente " + nome + " é maior de idade.");
            }
            else
            {
                Console.WriteLine("O paciente " + nome + " é idoso.");
            }
        }
    }
}
