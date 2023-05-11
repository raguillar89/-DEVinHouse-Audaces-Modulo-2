using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    public class Metodos
    {
        public static List<int> ReverseArray(List<int> list)
        {
            for (int i = 0; i < list.Count / 2; i++)
            {
                int tmp = list[i];
                list[i] = list[list.Count - i - 1];
                list[list.Count - i - 1] = tmp;
            }
            return list;
        }

        public static List<int> OrderArray(List<int> list)
        {
            var listSize = list.Count;
            for (var i = 0; i < listSize - 1; i++)
            {
                for (var j = 0; j < listSize - 1; j++)
                {
                    if (list[j] <= list[j + 1]) continue;
                    (list[j], list[j + 1]) = (list[j + 1], list[j]);                    
                }
            }
            return list;
        }

        public static int Sum(int sum, List<int> list)
        {
            foreach (var i in list)
            {
                sum += i;
            }
            return sum;
        }
    }
}
