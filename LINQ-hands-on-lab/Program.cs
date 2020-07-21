using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_hands_on_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1
            NumQuery();
            //Task2
            ObjectQuery();
        }

        //Task1
        static void NumQuery()
        {
            var numbers = new int[] { 1, 4, 9, 16, 25, 36 };
            var evenNumbers = from p in numbers
                              where (p % 2) == 0
                              select p;
            Console.WriteLine("Result:");
            foreach (var val in evenNumbers)
                Console.WriteLine(val);
        }

        //Task2
        static void ObjectQuery()
        {
            var results = from c in CreateCustomers()
                          where c.City == "London"
                          select c;
            foreach (var c in results)
                Console.WriteLine(c);
        }
        //Task2
        static IEnumerable<Customer> CreateCustomers()
        {
            return new List<Customer>
            {
                new Customer { CustomerID = "ALFKI", City = "Berlin"    },
                new Customer { CustomerID = "BONAP", City = "Marseille" },
                new Customer { CustomerID = "CONSH", City = "London"    },
                new Customer { CustomerID = "EASTC", City = "London"    },
                new Customer { CustomerID = "FRANS", City = "Torino"    },
                new Customer { CustomerID = "LONEP", City = "Portland"  },
                new Customer { CustomerID = "NORTS", City = "London"    },
                new Customer { CustomerID = "THEBI", City = "Portland"  }
            };
        }
    }
}
