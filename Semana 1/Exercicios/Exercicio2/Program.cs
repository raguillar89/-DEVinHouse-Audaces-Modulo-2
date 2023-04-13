using Exercicio2;

class Program
{
    private static void Main(string[] args)
    {
        Metodos m = new Metodos();

        Console.WriteLine("Digite um número inteiro: ");
        int num = int.Parse(Console.ReadLine());

        m.ParImpar(num);
        Console.ReadKey();
    }
}