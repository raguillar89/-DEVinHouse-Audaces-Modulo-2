internal class Program
{
    public static void Main(string[] args)
    {
        string frase = "A linguagem de programação C# é muito poderosa.";
        string[] palavras = frase.Split(' ');

        foreach(string palavra in palavras)
        {
            Console.WriteLine(palavra);
        }
        Console.WriteLine();

        Console.WriteLine(palavras[7]);
        Console.ReadKey();
    }
}