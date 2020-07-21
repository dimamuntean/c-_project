using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Customer
    {
        //get; set added later
        public string Name { get; set; }
        public string City { get; set; }
        public Order[] Orders { get; set; }
    }
}
