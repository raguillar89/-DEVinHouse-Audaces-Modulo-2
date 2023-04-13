using Exercicio10;

internal class Program
{
    public static void Main(string[] args)
    {
        Inicio:

        Console.WriteLine("Digite o primeiro número: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo número: ");
        double num2 = double.Parse(Console.ReadLine());
        
        Metodos m = new Metodos();

        m.Calc(num1, num2);

        Console.Write("Quer continuar calculando (s/n)?");
        string opcao = Console.ReadLine();

        if (opcao == "s" || opcao == "S")
        {
            goto Inicio;
        }

        Console.ReadKey();
    }
}