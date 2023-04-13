using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    class Metodos
    {
        public void Infos(string marca, string modelo, int kms)
        {
            if(kms < 10000)
            {
                Console.WriteLine("O veículo de marca " + marca + ", de modelo " + modelo + " e Km " + kms + " não precisa fazer revisão.");
            }
            else
            {
                Console.WriteLine("O veículo de marca " + marca + ", de modelo " + modelo + " e Km " + kms + " precisa fazer revisão.");
            }
        }
    }
}
