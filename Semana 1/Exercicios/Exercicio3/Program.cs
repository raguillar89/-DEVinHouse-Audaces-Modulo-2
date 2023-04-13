using Exercicio3;

class Program
{
    private static void Main(string[] args)
    {
        Metodos m = new Metodos();

        Console.WriteLine("Informe o nome do paciente: ");
        string nome = Console.ReadLine();

        Console.WriteLine();

        Console.WriteLine("Informe a idade do paciente: ");
        int idade = int.Parse(Console.ReadLine());

        m.NomeIdade(idade, nome);
    }
}