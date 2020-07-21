using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace b_ListExtension
{
    public static class ListExtension
    {
        public static void IncreaseWith(this IList<int> list, int number)
        {
            for(int i = 0; i < list.Count; i++)
            {
                list[i] += number;
            }
        }
    }
}
