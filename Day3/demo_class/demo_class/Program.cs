using demo_class.models;

namespace demo_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating an object using object initializer
            Bike myBike = new Bike { BikeID = 101, BikeName = "Yamaha R15", BikePrice = 180000 };

            // Printing bike details using ToString() override
            Bike myBike1 = new Bike { BikeID = 101, BikeName = "Yamaha R15", BikePrice = 180000 };
            Console.WriteLine(myBike1);

            // Modifying bike details using method
            myBike.SetBikeDetails(102, "Ducati Panigale V4", 2300000);

            // Display updated bike details
            Console.WriteLine("Updated Bike Details:");
            Console.WriteLine(myBike);

            // Creating an object using the constructor
            Bike myBike2 = new Bike(101, "Yamaha R15", 180000);

            // Displaying bike details
            Console.WriteLine(myBike2);


        }
    }
}
