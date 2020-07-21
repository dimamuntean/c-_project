using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            //a)
            Customer[] customers = new Customer[]{
                new Customer()
                {
                    City = "Beder",
                    Name = "Kim Foged",
                    Orders = new Order[3] { new Order() { Product = new Product() { Name = "Milk", Price = 20}, Quantity=1 },
                                            new Order() { Product = new Product() { Name = "Butter", Price = 30}, Quantity=2 },
                                            new Order() { Product = new Product() { Name = "Bread", Price = 10}, Quantity=3 }}
                },                                          

                new Customer()
                {
                    City = "Horsens",
                    Name = "Ib Havn",
                    Orders = new Order[4] { new Order() { Product = new Product() { Name = "Milk", Price = 20}, Quantity=1 },
                                            new Order() { Product = new Product() { Name = "Butter", Price = 30}, Quantity=2 },
                                            new Order() { Product = new Product() { Name = "Bread", Price = 10}, Quantity=1 },
                                            new Order() { Product = new Product() { Name = "Cacao", Price = 40}, Quantity=3 }}
                },
                new Customer()
                {
                    City = "Horsens",
                    Name = "Rasmus Bjerner",
                    Orders = new Order[1] { new Order() { Product = new Product() { Name = "Apple Juice", Price = 44}, Quantity=1 }}
                }
            };


            //b) 
            Console.WriteLine("b)");
            var res1 = from customer in customers
                       select new { Name = customer.Name, City = customer.City};

            foreach (var c in res1)
                Console.WriteLine(c);

            //c)
            Console.WriteLine("c)");
            var res2 = from customer in customers
                                         where customer.City == "Horsens"
                                         select customer.Name;
            foreach (var c in res2)
                Console.WriteLine(c);

            //d)
            Console.WriteLine("d)");
            var res3 = (from customer in customers
                       where customer.Name == "Ib Havn"
                       from order in customer.Orders
                       select order.Quantity).Sum();
            Console.WriteLine(res3);

            //e)
            Console.WriteLine("e)");
            var res4 = from customer in customers
                                         from order in customer.Orders
                                         where order.Product.Name == "Milk"
                                         select customer.Name;
            foreach (var c in res4)
                Console.WriteLine(c);

            //f)
            Console.WriteLine("f)");
            var res5 = from customer in customers
                       from order in customer.Orders
                       group order by customer.Name into gr
                       select new { Person = gr.Key, Sum = gr.Sum(o => o.Product.Price*o.Quantity)};
            foreach (var c in res5)
                Console.WriteLine(c);

            //g)
            Console.WriteLine("f)");
            var res6 = (from customer in customers
                       from order in customer.Orders
                       select order.Product.Price * order.Quantity).Sum();
           
            Console.WriteLine("Total sum: " + res6);
            Console.ReadKey();

        }
    }
}
