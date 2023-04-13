using Exercicio7;

class Program
{
    public static void Main(string[] args)
    {
        Metodos m = new Metodos();

        Console.WriteLine("Digite um número inteiro: ");
        int num = int.Parse(Console.ReadLine());

        m.Pares(num);
        Console.ReadKey();
    }
}