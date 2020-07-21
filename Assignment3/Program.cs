using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Program
    {
        //a)
        static void Main(string[] args)
        {
            //b)
            Pair<String, int> pair1 = new Pair<String, int>("Kurt", 13);

            //c)
            Pair<String, double> pair2 = new Pair<String, double>("Phoenix", 39.7);

            //d)
            //pair1 = pair2; Wrong, they are different

            //e)
            Pair<String, int>[] grades;
            var array = new Pair<String, int>[5];
            grades = array;
            grades[0] = new Pair<String, int>("DNP", 10);
            grades[1] = new Pair<String, int>("SMP", 12);
            grades[2] = new Pair<String, int>("SDJ", 7);

            //f)
            foreach(var grade in grades)
            {
                Console.WriteLine(grade);
            }
            // For those unassigned the value is ( , 0);


            //g) 
            Pair<Pair<int, int>, String> appointment = new Pair<Pair<int, int>, String>(new Pair<int, int>(12, 30), "Monday");
            var a = appointment.first.second; // int

            //h) test
            var p = pair1.Swap();
            Console.WriteLine(pair1);
            Console.WriteLine(p);


            Console.ReadLine();
        }
    }
}
