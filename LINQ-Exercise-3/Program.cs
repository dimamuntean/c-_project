using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arr = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j',  };

            int size = 3;
            int i = 0;
            var res = from item in arr
                      group item by Math.Abs(i - i++ % size)  into part
                      select part.AsEnumerable();

            foreach (var l in res)
            {
                Console.Write("[");

                foreach(var el in l)
                {
                    Console.Write(el + ((el == l.Last()) ? "" : ", "));
                }

                Console.WriteLine("]");
            }

            Console.Read();
        }
    }
}
