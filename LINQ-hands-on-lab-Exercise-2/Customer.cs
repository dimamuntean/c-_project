using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_hands_on_lab_Exercise_2
{
    public class Customer
    {
        public string CustomerID { get; set; }
        public string City { get; set; }
        public override string ToString()
        {
            return CustomerID + "\t" + City;
        }
    }
}
