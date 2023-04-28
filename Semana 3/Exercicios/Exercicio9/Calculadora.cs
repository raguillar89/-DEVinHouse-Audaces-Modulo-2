using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio9
{
    public static class Calculadora
    {
        public const double pi = 3.1415926559;

        public static double Somar(double n1, double n2)
        {
            return n1 + n2;
        }

        public static double Subtrair(double n1, double n2)
        {
            return n1 - n2;
        }

        public static double Multiplicar(double n1, double n2)
        {
            return n1 * n2;
        }

        public static double Dividir(double n1, double n2)
        {
            return n1 / n2;
        }
    }
}
