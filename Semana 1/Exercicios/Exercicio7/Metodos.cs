using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio7
{
    class Metodos
    {
        public void Pares(int num2)
        {
            for(int i = 0; i < num2; i++)
            {
                if(i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
