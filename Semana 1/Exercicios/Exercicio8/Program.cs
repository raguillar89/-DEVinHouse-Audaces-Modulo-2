class Program
{
    public static void Main(string[] args)
    {
        int[] numeros = new int[5];

        Console.WriteLine("Digite cinco números inteiros: ");
        for(int i = 0; i < numeros.Length; i++)
        {
            numeros[i] = int.Parse(Console.ReadLine());
        }

        int maiorValor = numeros.Max();

        Console.WriteLine("O maior valor na listagem é " + maiorValor);
        Console.ReadKey();
    }
}