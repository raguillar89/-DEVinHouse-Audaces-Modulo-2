namespace Exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria cb = new ContaBancaria("64326", 1000);
            cb.Depositar(3000);
            cb.Sacar(1600);

            Console.ReadKey();
        }
    }
}