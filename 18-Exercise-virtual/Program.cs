using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_Exercise_virtual
{
    class Program
    {
        static void Main(string[] args)
        {
            B classB = new B();
            B.SM();
            classB.NIM();
            classB.VIM();

            C classC = new C();
            C.SM();
            classC.NIM();
            classC.VIM();

            C classC2 = new C();
            B classB2 = classC2;

            classB2.NIM();
            classB2.VIM();
            classC2.NIM();
            classC2.VIM();

            Console.ReadKey();
        }
    }
}
