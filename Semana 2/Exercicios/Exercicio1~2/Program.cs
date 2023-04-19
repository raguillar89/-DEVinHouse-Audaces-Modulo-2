namespace Exercicio1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Metodos m = new Metodos();
            m.Somar(3,4);
            double result1 = m.Calcular(3.2,5.4);
            double result2 = m.Calcular(5.4,1.2,8.9);

            Console.WriteLine("O resultado a soma é: " + result1);
            Console.WriteLine("O resultado a soma é: " + result2);

            Console.ReadKey();
        }
    }
}