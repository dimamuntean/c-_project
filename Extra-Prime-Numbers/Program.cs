using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra_Prime_Numbers
{
    using int_extension;
    class Program
    {
        static void Main(string[] args)
        { 

           Func<int, List<int>> primes = x => {
               List<int> res = new List<int>();
               bool composite;
                for(int i = 1; i < x; i++)
               {
                   composite = false;
                   for(int j = 2; j < i; j++)
                   {
                       if (i % j == 0)
                       {
                           composite = true;
                           break;
                       }
                   }
                   if(!composite)
                   {
                       res.Add(i);
                   }
               }
               return res;
           };

            List<int> prim = primes(100);

            prim.ForEach(Console.WriteLine);
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine("Extension method: ");
            List<int> prim2 = 100.Prime();
            prim2.ForEach(Console.WriteLine);
            Console.ReadKey();
        }
    }
}
