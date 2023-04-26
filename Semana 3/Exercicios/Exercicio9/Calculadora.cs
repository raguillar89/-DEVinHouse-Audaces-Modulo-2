using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio9
{
    static class Calculadora
    {
        public const double pi = 3.1415926559;

        public static void Somar(double n1, double n2)
        {
            double total = n1 + n2;
            Console.WriteLine($"Total da Soma: {total}");
        }

        public static void Subtrair(double n1, double n2)
        {
            double total = n1 - n2;
            Console.WriteLine($"Total da Subtração: {total}");
        }

        public static void Multiplicar(double n1, double n2)
        {
            double total = n1 * n2;
            Console.WriteLine($"Total da Multiplicação: {total}");
        }

        public static void Dividir(double n1, double n2)
        {
            double total = n1 / n2;
            Console.WriteLine($"Total da Divisão: {total}");
        }
    }
}
