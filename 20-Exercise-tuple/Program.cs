using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _20_Exercise_tuple
{
    class Program
    {
        private static (int, int) GetAverageAndSum(int[] numbers)
        {
            return (numbers.Sum(), numbers.Sum()/numbers.Length);
        }
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };

            (int sum, int average) res = GetAverageAndSum(numbers);

            Console.WriteLine("Sum: " + res.sum);
            Console.WriteLine("Average: " + res.average);
            Console.ReadKey();
        }
    }
}
