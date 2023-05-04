using Exercicio1ao10.Service;

namespace Exercicio1ao10
{
    class Program
    {
        static void Main(string[] args)
        {            
            MenuService menuService = new MenuService();
            menuService.ExibirMenu();
        }
    }
}