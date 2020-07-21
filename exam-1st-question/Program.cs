using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_1st_question
{
    public class A
    {
        private int value = 10;

        public class B : A
        {
            public int GetValue()
            {
                return this.value;
            }
        }
    }

    public class C : A
    {
        public int GetValue()
        {
            return this.value;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
