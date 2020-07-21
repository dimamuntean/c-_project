using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace int_extension
{
    public static class Extension
    {
        public static List<int> Prime(this int itg)
        {
            List<int> res = new List<int>();
            bool composite;
            for (int i = 1; i < itg; i++)
            {
                composite = false;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        composite = true;
                        break;
                    }
                }
                if (!composite)
                {
                    res.Add(i);
                }
            }
            return res;
        }
    }
}
