using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1ClassLibrary
{
    public class Hand
    {

        private List<Car> cars;

        public Hand()
        {
            cars = new List<Car>();
        }
        public void AddCarToHand(Car car)
        {
            cars.Add(car);
        }

        public void AddCarRangeToHand(Car[] carRange)
        {
            cars.AddRange(carRange);
        }
        public List<Car> getCars(int maxSpeed)
        {
            return cars.Count == 0 ? new List<Car>() : cars.Where(x => x.MaxSpeed < maxSpeed).ToList<Car>();
        }
    }
}
