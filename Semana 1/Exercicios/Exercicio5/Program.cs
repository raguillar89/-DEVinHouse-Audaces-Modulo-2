class Program
{
    public static void Main(string[] args)
    {
        int[] numeros = new int[4];

        Console.WriteLine("Digite 4 números inteiros");

        for (int i = 0; i < numeros.Length; i++)
        {
            numeros[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Array original: ");
        foreach (int i in numeros)
        {
            Console.Write(i + " ");
        }

        Console.WriteLine();

        Array.Sort(numeros);

        Console.WriteLine("Array em ordem crescente: ");
        foreach (int i in numeros)
        {
            Console.Write(i + " ");
        }
    }
}