using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    // Delegate types to describe predicates on ints and actions on ints.
    public delegate bool IntPredicate(int x);
    public delegate void IntAction(int x);

    // Integer lists with Act and Filter operations.
    // An IntList containing the element 7 9 13 may be constructed as  // new IntList(7, 9, 13) due to the params modifier. 
    class IntList : List<int>
    {
        public IntList(params int[] elements) : base(elements) { }
        public void Act(IntAction f)
        {
            foreach (int i in this)
            {
                f(i);
            }
        }

        public IntList Filter(IntPredicate p)
        {
            IntList res = new IntList();
            foreach (int i in this)
                if (p(i))
                    res.Add(i);
            return res;
        }
    }

    class Program
    {
        public static void Main(String[] args)
        {
            var xs = new IntList { 1, 122, 3, 4, 5 };
            xs.Act(Console.WriteLine);

            Console.WriteLine("Print only even numbers:");
            xs.Filter(delegate (int x) { return x % 2 == 0; }).Act(Console.WriteLine);

            Console.WriteLine("Using anonymous methods: (x >= 25) ");
            xs.Act(delegate (int x) { if (x >= 25) Console.WriteLine(x); });
            // xs.Filter(delegate (int x) { return x >= 25; }).Act(Console.WriteLine);

            Console.WriteLine("Computing sum: ");
            int sum = 0;
            xs.Act(delegate (int x) { sum += x; });
            Console.WriteLine(sum);

            //Generic
            Console.WriteLine("Generics");
            var gs = new MyList<int> { 1, 122, 3, 4, 5 };
            gs.Act(Console.WriteLine);

            Console.WriteLine("Print only even numbers:");
            gs.Filter(delegate (int x) { return x % 2 == 0; }).Act(Console.WriteLine);

            Console.WriteLine("Using anonymous methods: (x >= 25) ");
            gs.Act(delegate (int x) { if (x >= 25) Console.WriteLine(x); });
            // gs.Filter(delegate (int x) { return x >= 25; }).Act(Console.WriteLine);

            Console.WriteLine("Computing sum: ");
            int sumg = 0;
            gs.Act(delegate (int x) { sumg += x; });
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
