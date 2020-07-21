using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Exercise_lambda2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Kim", "Jesper", "Mads", "Morten", "Rasmus" };

            IEnumerable<string> new_names = names.OrderBy(name => name[0]); // Orderby is an extenstion method to standard string class

            foreach(var name in new_names)
            {
                Console.WriteLine(name);
            }
            Console.ReadKey();
        }
    }
}
