namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente c = new Cliente("Renan Pinho", "123544534");
            ContaBancaria cb = new ContaBancaria("57892445-5", c);

            Console.Write("Digite o valor que gostaria de depositar: R$");
            double depositar = double.Parse(Console.ReadLine());
            cb.Depositar(depositar);
            cb.ExibirDados();

            Console.Write("\nDigite o valor que gostaria de sacar: R$");
            double sacar = double.Parse(Console.ReadLine());
            cb.Sacar(sacar);
            cb.ExibirDados();

            Console.ReadKey();
        }
    }
}