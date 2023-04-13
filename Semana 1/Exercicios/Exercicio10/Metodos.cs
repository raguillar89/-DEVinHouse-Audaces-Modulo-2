using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio10
{
    class Metodos
    {
        public void Calc(double num1, double num2)
        {
            Console.Write("Escolha a operação: \n Soma (+) \n Divisão (-) \n Multiplicação (x) \n Divisão (/) \n Resto (%) \n");
            char op = char.Parse(Console.ReadLine());

            double resultado;

            switch (op)
            {
                default:
                    Console.WriteLine("Erro, opção inválida.");
                    break;

                case '+':
                    resultado = num1 + num2;
                    Console.WriteLine("O resultada da soma é: " + resultado);
                    break;

                case '-':
                    resultado = num1 - num2;
                    Console.WriteLine("O resultada da subtração é: " + resultado);
                    break;

                case '*':
                case 'X':
                case 'x':
                    resultado = num1 * num2;
                    Console.WriteLine("O resultada da multiplicação é: " + resultado);
                    break;

                case ':':
                case '/':
                    if (num2 == 0)
                    {
                        Console.WriteLine("Não é possível dividir por 0.");
                    }
                    else
                    {
                        resultado = num1 / num2;
                        Console.WriteLine("O resultada da divisão é: " + resultado);
                    }
                    break;

                case '%':
                    resultado = num1 % num2;
                    Console.WriteLine("O resultada do resto é: " + resultado);
                    break;
            }
        }
    }
}
