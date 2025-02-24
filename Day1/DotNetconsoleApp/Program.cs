namespace DotNetconsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Registration Form");
            Console.WriteLine("Enter Your Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Your Age");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Your Email");
            string email = Console.ReadLine();
            Console.WriteLine("Enter Your Password");
            string password = Console.ReadLine();

            Console.WriteLine("Enter Your Mobile Number");
            string mobile = Console.ReadLine();
            Console.WriteLine($"Name{name}\n Age{age}\nEmail{email}\n sucessfully registered"  );

        }
    }
}
