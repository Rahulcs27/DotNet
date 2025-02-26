using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_inheritance.Model
{
    internal class Vehicle
    {
        public string Brand { get; set; }
        public int Speed { get; set; }

        // Constructor for base class
        public Vehicle(string brand, int speed)
        {
            Brand = brand;
            Speed = speed;
        }

        // Virtual method for overriding
        public virtual void GetAllDetails()
        {
            Console.WriteLine($"Brand: {Brand}, Speed: {Speed} km/h");
        }
    }
}
