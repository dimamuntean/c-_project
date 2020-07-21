using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1Library
{
    class Car : IComparable<Car>
    {
        public double MaxSpeed { get; set; } //km/h field in the assignment
        public double Power { get; set; } // PS/kW in the assignment
        public double RPM { get; set; } // revolution per minute = U/min
        public double CCM { get; set; } // central control module
        public double UpToHundred { get; set; }
        public int Cylinder { get; set; } // number of cilyndres

        public CompareBy Compare { get; set; } = CompareBy.MaxSpeed;
        public enum CompareBy // static by definition
        {
            MaxSpeed,
            Power,
            RPM,
            CCM,
            UpToHundred,
            Cylinder
        }
        public int CompareTo(Car other)
        {
            if ((other == null) || !this.GetType().Equals(other.GetType()))
                return 1;

            Car car = other as Car;
            
            if(car == null)
                throw new ArgumentException("Object is not a Temperature");
            else
            {
                switch (car.Compare)
                {
                    case CompareBy.CCM:
                        return CCM.CompareTo(car.CCM);
                    case CompareBy.Cylinder:
                        return Cylinder.CompareTo(car.Cylinder);
                    case CompareBy.Power:
                        return Power.CompareTo(car.Power);
                    case CompareBy.RPM:
                        return RPM.CompareTo(car.RPM);
                    case CompareBy.UpToHundred:
                        return UpToHundred.CompareTo(car.UpToHundred);
                    default:
                        return MaxSpeed.CompareTo(car.MaxSpeed); // Max Speed is default
                }
            }
        }

        public override string ToString()
        {
            String res = "MaxSpeed = " + MaxSpeed 
                       + "\nPower = " + Power
                       + "\nRPM = " + RPM 
                       + "\nCCM = " + CCM 
                       + "\nTo 100 km/h = " + UpToHundred
                       + "\nCylinders = " + Cylinder;
            return res;
        }
    }
}
