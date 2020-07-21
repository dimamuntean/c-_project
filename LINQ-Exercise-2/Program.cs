using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            IEnumerable<int> result = from num in numbers
                                      select num * 5;
         
            foreach(int num in result)
            {
                Console.WriteLine(num);
            }

            Console.ReadKey();
        }
    }
}
