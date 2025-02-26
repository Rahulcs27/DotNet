using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_inheritance.Model
{
    internal class Bike : Vehicle
    {
        public string Type { get; set; }

        // Constructor calling base class constructor
        public Bike(string brand, int speed, string type) : base(brand, speed)
        {
            Type = type;
        }


        // Overriding the method to add extra details
        public override void GetAllDetails()
        {
            base.GetAllDetails(); // Calls base class method
            Console.WriteLine($"Type: {Type}");
        }
    }
}
