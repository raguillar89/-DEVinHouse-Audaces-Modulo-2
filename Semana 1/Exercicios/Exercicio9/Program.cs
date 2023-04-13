class Program
{
    public static void Main(string[] args)
    {
        double somaValores = 0;
        int numElementos;
        double mediaAritmetica;
        int[] numeros;

        Console.WriteLine("Informe o número de elementos do array: ");
        numElementos = Convert.ToInt32(Console.ReadLine());
        numeros = new int[numElementos];

        Console.WriteLine("Informe os valores que gostaria de calcular a média aritmética: ");
        for(int i = 0; i < numElementos; i++)
        {
            numeros[i] = Convert.ToInt32(Console.ReadLine());
        }

        for(int i = 0; i < numeros.Length; i++)
        {
            somaValores += numeros[i];
        }

        mediaAritmetica = (somaValores / numeros.Length);

        Console.WriteLine("A média Aritmética da lista é " + mediaAritmetica);
        Console.ReadKey();
    }
}