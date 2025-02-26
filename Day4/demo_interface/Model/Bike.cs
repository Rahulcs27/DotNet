using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_interface.Model
{
    class Bike : IBike,IOrder
    {
        public string Model { get; set; }
        public double Price { get; set; }

        public Bike(string model, double price)
        {
            Model = model;
            Price = price;
        }
        public void start()
        {
            Console.WriteLine("Bike started");
        }
        public void stop()
        { 
            Console.WriteLine("Bike stopped"); 
        }
        public void processOrder()
        {
            Console.WriteLine($"Order processed for {Model}");
        }
        public void cancelOrder()
        {
            Console.WriteLine($"Order cancelled for {Model}");
        }
    }
}
