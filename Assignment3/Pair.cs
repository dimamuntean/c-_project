using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    //a)
    public struct Pair<T, U>
    {
        public readonly T first;
        public readonly U second;
        public Pair(T fst, U snd)
        {
            this.first = fst;
            this.second = snd;
        }

        //h)
        public Pair<U, T> Swap()
        {
            return new Pair<U, T>(second, first);
        }
        public override String ToString()
        {
            return "(" + first + ", " + second + ")";
        }
    }
}
