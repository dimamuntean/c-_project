using Assignment1ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Program
    {
        public static List<Car> GetCards()
        {
            List<Car> cars = new List<Car>();
            cars.Add(new Car()
            {
                CCM = 2994,
                Cylinder = 6,
                MaxSpeed = 265,
                Power = 300,
                RPM = 5900,
                UpToHundred = 6.0,
                Compare = Car.CompareBy.CCM
            });
            cars.Add(new Car()
            {
                CCM = 2343,
                Cylinder = 5,
                MaxSpeed = 220,
                Power = 230,
                RPM = 5340,
                UpToHundred = 9.0
            });
            cars.Add(new Car()
            {
                CCM = 2434,
                Cylinder = 3,
                MaxSpeed = 123,
                Power = 140,
                RPM = 3400,
                UpToHundred = 12.0
            });
            cars.Add(new Car()
            {
                CCM = 2433,
                Cylinder = 4,
                MaxSpeed = 250,
                Power = 230,
                RPM = 5430,
                UpToHundred = 10.0
            });
            return cars;
        }
        private static void print(List<Car> cards)
        {
            foreach (var car in cards)
                Console.WriteLine(car);
            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }
        public static void SortCard()
        {
            Console.WriteLine("Sort card test...");
            List<Car> cars = GetCards();
            cars.Sort();
            print(cars);
        }
        public static void HandTest()
        {
            Console.WriteLine("Hand test...");
            List<Car> cards = GetCards();
            Hand hand = new Hand();
            foreach(var card in cards)
            {
                hand.AddCarToHand(card);
            }

            print(hand.getCars(200));
        }

        static void Main(string[] args)
        {
            SortCard();
            HandTest();
        }
    }
}
