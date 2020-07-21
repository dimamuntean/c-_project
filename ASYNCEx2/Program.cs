using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ASYNCEx2
{
    class Program
    {
        public static void Task1()
        {
            Thread.Sleep(5000);
        }
        public static String Task2()
        {
            Thread.Sleep(5000);
            return "Hi there";
        }
        public static Task Task1Method()
        {
            return Task.Run(() => Task1());
        }

        public static Task<String> Task2Method()
        {
            return Task.Run(() => Task2());
        }

        public async static void test()
        {
            String s = await Task2Method();
            Console.WriteLine(s);
        }
        static void Main(string[] args)
        {
            Task1Method();
            test();
            Console.ReadKey();

            /**
             * Async void methods have different error-handling semantics.
             * When an exception is thrown out of an async Task or async 
             * Task method, that exception is captured and placed on the 
             * Task object. With async void methods, there is no Task object,
             * so any exceptions thrown out of an async void method will be raised
             * directly on the SynchronizationContext that was active when the 
             * async void method started.
             */
        }
    }
}
