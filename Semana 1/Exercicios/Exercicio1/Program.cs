using Exercicio1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    private static void Main(string[] args)
    {
        Metodos m = new Metodos();

        Console.WriteLine("Digite dois números inteiros para saber a soma deles.");
        int n1 = int.Parse(Console.ReadLine());
        int n2 = int.Parse(Console.ReadLine());

        m.Soma(n1, n2);
        Console.ReadKey();
    }
}