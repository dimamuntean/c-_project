using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _050918Exercises
{

    class Program
    {
        
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 7, 1, 3, 4, 10, 12, 14, 7, 6, 5, 3, 1, 4 };

            Predicate<int> predicateDelegate = delegate (int val)
            {
                return val > 7;
            };
 
            int[] res = Array.FindAll(arr, predicateDelegate);
            Array.ForEach(res, Console.WriteLine);
            Console.ReadLine();
        }
    }
}
