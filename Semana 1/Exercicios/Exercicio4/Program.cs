using Exercicio4;

class Program
{
    private static void Main(string[] args)
    {
        Metodos m = new Metodos();

        Console.WriteLine("Informe a marca do veículo: ");
        string marca = Console.ReadLine();

        Console.WriteLine("Informe o modelo do veículo: ");
        string modelo = Console.ReadLine();

        Console.WriteLine("Informe a quilometragem do veículo: ");
        int kms = int.Parse(Console.ReadLine());

        m.Infos(marca, modelo, kms);
        Console.ReadKey();
    }
}