internal class Program
{
    public static void Main(string[] args)
    {
        string frase = "A linguagem de programação C# é muito poderosa";
        List<string> palavras = new List<string>(frase.Split(' '));

        foreach(string palavra in palavras)
        {
            if(palavra == "poderosa")
            {
                Console.WriteLine(palavra);
            }
        }
        Console.ReadKey();
    }
}