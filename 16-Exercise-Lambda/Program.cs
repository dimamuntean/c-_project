using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Exercise_Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Kim", "Jesper", "Mads", "Morten", "Rasmus" };

            Console.WriteLine("Exercise 1 : Predicate");
            Predicate<string> predicate = MoreThanThreeLetters;
            Predicate<string> predicateDelegate = delegate (string val)
             {
                 return val.Length > 3;
             };
            Predicate<string> predicateLambda = s => s.Length > 3;

            string[] names1 = Array.FindAll<String>(names, predicate);
            print(names1);

            Console.WriteLine("Exercise 2 : Anonymos");

            string[] names2 = Array.FindAll<String>(names, delegate (string val)
            {
                return val.Length > 3;
            });

            print(names2);

            Console.WriteLine("Exercise 3 : Lambda");
            string[] names3 = Array.FindAll<String>(names, elem => elem.Length > 3);
            print(names3);

            Console.ReadKey();
        }

        public static bool MoreThanThreeLetters(string val)
        {
            return val.Length > 3;
        }
        public static void print(string[] values)
        {
            foreach (var val in values)
                Console.WriteLine(val);
        }
    }
}
