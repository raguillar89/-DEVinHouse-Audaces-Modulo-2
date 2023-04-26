namespace Exercicio1
{
    class Program
    {
        private static void Main(string[] args)
        {
            Pessoa p = new Pessoa("Renan", 34, "Rua ABC, 34");
            p.Saudacao();

            Console.ReadKey();
        }
    }
}