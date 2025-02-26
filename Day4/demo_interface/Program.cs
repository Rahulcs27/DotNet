using demo_interface.Model;

namespace demo_interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bike bike = new Bike("Hero-Splendor", 100000);

            //bike interface functions are called
            bike.start();
            bike.stop();

            //order interface functions are called
            bike.processOrder();
            bike.cancelOrder();

        }
    }
}
