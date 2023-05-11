namespace Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = new List<int> { 1, 2, 3, 4, 5 };
            IEnumerable<int> reverse = Metodos.ReverseArray(list1);
            Console.Write("Lista Decrescente: ");
            foreach (int i in reverse)
            {
                Console.Write(i + " ");
            }

            List<int> list2 = new List<int> { 2, 8, 1, 0, 6, 10, -1, -6 };
            IEnumerable<int> order = Metodos.OrderArray(list2);
            Console.Write("\n\nOrdenando a lista: ");
            foreach (int i in order)
            {
                Console.Write(i + " ");
            }

            List<int> list3 = new List<int> { -1, 2, 3, 4, 5 };
            var sum = 0;
            var result = Metodos.Sum(sum, list3);
            Console.WriteLine($"\n\nTotal = {result}");

            Console.WriteLine();
            Console.ReadKey();
        }                    
    }
}