using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_Exercise_virtual
{
    class C: B
    {
        public new static void SM() { Console.WriteLine("Hello from C.SM()!"); }
        public override void VIM() { Console.WriteLine("Hello from C.VIM()!"); }
        public new void NIM() { Console.WriteLine("Hello from C.NIM()"); }
    }
}
