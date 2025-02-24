namespace demo_structure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            address add = new address();
            add.street = "123 Main St";
            add.city = "Anytown";
            add.state = "NY";
            add.zip = 12345;
            Console.WriteLine($"Street ::{add.street}\tCity::{add.city}\tState::{add.state}\tzip::{add.zip}");
        }
    }
}
