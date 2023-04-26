namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria cb = new ContaBancaria();

            Console.Write("Digite o valor que gostaria de depositar: R$");
            double depositar = double.Parse(Console.ReadLine());
            cb.Depositar(depositar);

            Console.Write("\nDigite o valor que gostaria de sacar: R$");
            double sacar = double.Parse(Console.ReadLine());
            cb.Sacar(sacar);

            Console.ReadKey();
        }
    }
}