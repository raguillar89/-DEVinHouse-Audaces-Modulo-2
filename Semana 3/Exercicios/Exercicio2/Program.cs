namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria c = new ContaBancaria("57892445-5");

            Console.Write("Digite o valor que gostaria de depositar: R$");
            double depositar = double.Parse(Console.ReadLine());
            c.Depositar(depositar);

            Console.Write("\nDigite o valor que gostaria de sacar: R$");
            double sacar = double.Parse(Console.ReadLine());
            c.Sacar(sacar);

            Console.WriteLine("\nSaldo: R$" + c.Saldo);
            Console.ReadKey();
        }
    }
}