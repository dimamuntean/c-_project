using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    // Delegate types to describe predicates on ints and actions on ints.
    public delegate bool IntPredicate<T>(T x);
    public delegate void IntAction<T>(T x);

    // Integer lists with Act and Filter operations.
    // An IntList containing the element 7 9 13 may be constructed as  // new IntList(7, 9, 13) due to the params modifier. 
    class MyList<T> : List<T>
    {
        public MyList(params T[] elements) : base(elements) { }
        public void Act(IntAction<T> f)
        {
            foreach (var i in this)
            {
                f(i);
            }
        }

        public MyList<T> Filter(IntPredicate<T> p)
        {
           MyList<T> res = new MyList<T>();
            foreach (var i in this)
                if (p(i))
                    res.Add(i);
            return res;
        }
    }

}
