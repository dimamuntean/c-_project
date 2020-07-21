﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LINQ_hands_on_lab_Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            ObjectQuery();
            XMLQuery();
        }
        public static void XMLQuery()
        {
            var doc = XDocument.Load("Customers.xml");
            var results = 
                from c in doc.Descendants("Customer")
                where c.Attribute("City").Value == "London"
                select c;

            //Console.WriteLine("Results:\n");
            // Task 3.1
            //Console.WriteLine("XML Document:\n{0}", doc);
            // Task 3.3
            //foreach (var contact in results)
            //    Console.WriteLine("{0}\n", contact);
            // Task 4
            XElement transformedResults = new XElement("Londoners", 
                from customer in results
                select new XElement("Contact", new XAttribute("ID", customer.Attribute("CustomerID").Value), 
                       new XElement("Name", customer.Attribute("ContactName").Value), 
                       new XElement("City", customer.Attribute("City").Value)));

            Console.WriteLine("Results:\n{0}", transformedResults);
            // Task 4.3
            transformedResults.Save("Output.xml");
        }
        static void ObjectQuery()
        {
            var results = from c in CreateCustomers()
                          where c.City == "London"
                          select c;
            foreach (var c in results)
                Console.WriteLine(c);
        }
        static IEnumerable<Customer> CreateCustomers()
        {
            return 
                from c in XDocument.Load("Customers.xml").Descendants("Customers").Descendants()
                select new Customer {
                    City = c.Attribute("City").Value,
                    CustomerID = c.Attribute("CustomerID").Value
                };
        }
    }
}
