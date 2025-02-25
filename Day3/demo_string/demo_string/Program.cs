using System.Text;

namespace demo_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Using string (Inefficient)
            string str = "Hello";
            str += " World";  // Creates new string every time
            Console.WriteLine(str);  // Output: Hello World

            // Using StringBuilder (Efficient)
            StringBuilder sb = new StringBuilder("Hello");
            sb.Append(" World");
            Console.WriteLine(sb.ToString());  // Output: Hello World

        }
    }
}
