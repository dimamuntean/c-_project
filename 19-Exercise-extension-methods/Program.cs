using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Exercise_extension_methods
{
    using a_StringExtension;
    using b_ListExtension;
    using c_IEnumerable;
    class Program
    {
        static void Main(string[] args)
        {
            //a)
            string helloString = "Hello, Extension Methods!";
            int wordCount = helloString.WordCount();
            Console.WriteLine(wordCount);
            Console.ReadLine();

            //b)
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            numbers.IncreaseWith(5);
            numbers.ForEach(Console.WriteLine);
            Console.ReadKey();

            //c)
            List<int> numbers2 = new List<int> { 1, 2, 3, 4, 5 };
            Console.WriteLine(numbers2.ToString<int>());
            Console.ReadKey();
        }
    }
}

