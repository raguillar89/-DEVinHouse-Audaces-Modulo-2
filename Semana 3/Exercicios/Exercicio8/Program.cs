namespace Exercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            Cachorro c = new Cachorro();
            c.EmitirSom();

            Gato g = new Gato();
            g.EmitirSom();

            Console.ReadKey();
        }
    }
}