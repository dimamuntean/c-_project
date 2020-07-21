using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a_StringExtension
{
    //must be static
    public static class StringExtension
    {   
        // must be static
        public static int WordCount(this String str) // Here you specify the type it refers to
        {
            return str.Split(new char[] {',', ' ', '.'}, 
                StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
}
