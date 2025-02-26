using demo_inheritance.Model;

namespace demo_inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating an object of Bike class
            Bike myBike = new Bike("Yamaha", 120, "Sports");

            // Calling method to display details
            myBike.GetAllDetails();
        }
    }
}
