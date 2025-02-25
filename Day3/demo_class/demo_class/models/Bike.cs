using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_class.models
{
    internal class Bike
    {
        // Auto-implemented properties
        public int BikeID { get; set; }
        public string BikeName { get; set; }
        public int BikePrice { get; set; }

        // Method to update bike details
        public void SetBikeDetails(int id, string name, int price)
        {
            BikeID = id;
            BikeName = name;
            BikePrice = price;
        }
        // Constructor: Initializes values when the object is created
        public Bike(int id, string name, int price)
        {
            BikeID = id;
            BikeName = name;
            BikePrice = price;
        }
        // Override ToString() method
        public override string ToString()
        {
            return $"Bike ID: {BikeID}, Name: {BikeName}, Price: ${BikePrice}";
        }


    }
}
