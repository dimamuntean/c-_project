using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_IEnumerable
{
    public static class IEnumerable
    {
        public static String ToString<T>(this IEnumerable<T> enumerable)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("[");
            foreach(var item in enumerable)
            {
                sb.Append(item + (item.Equals(enumerable.Last())?"":","));
            }
            sb.Append("]");
            return sb.ToString();
        }
    }
}
