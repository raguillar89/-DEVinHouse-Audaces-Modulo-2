using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1_2
{
    class Metodos
    {
        public void Somar(int n1, int n2)
        {   
            int resultado = n1 + n2;
            Console.WriteLine("O resultado da soma é: " + resultado);
        }

        public double Calcular(params double[] param)
        {
            double resultado = 0;

            foreach (var num in param)
            {
                resultado += num;
            }

            return resultado;
        }
    }
}
