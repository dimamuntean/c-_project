using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Exercise_1
{
    class Program
    {
        private static void a(String[] names)
        {
            Console.WriteLine("a) ....");
            IEnumerable<String> a =
                                    from name in names
                                    where name.Contains('K')
                                    select name.Replace("K", "C");

            foreach (var name in a)
            {
                Console.WriteLine(name);
            }
        }
        private static string removeVowels(String value)
        {
            String vowels = "aeiouyAEIOUY";

            return new string(value.Where(c => !vowels.Contains(c)).ToArray());
        } 
        private static void b(String[] names)
        {
            //Not done yet
            Console.WriteLine("b) ....");
            var vowels = new char[] { 'a', 'e', 'i', 'o', 'u', 'y' };

            IEnumerable<String> b =
                                    from name in names
                                   // where true //name.IndexOfAny(vowels) != -1 // only strings with vowels will be returned
                                    select removeVowels(name);

            foreach (var name in b)
            {
                Console.WriteLine(name);
            }
        }
        static void Main(string[] args)
        {
            var names = new[] { "Kim", "Kurt", "Karsten", "Klaus", "Kay"};

            a(names);
            b(names);

            Console.ReadKey();
        }
    }
}
