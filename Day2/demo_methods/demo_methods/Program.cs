using System.Runtime.InteropServices;

namespace demo_methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //calculate the area of circle and circumference of circle using out keyword
            Console.WriteLine("Enter the Radius");
            double radius = Convert.ToDouble(Console.ReadLine());
            CalculateAreaOfCircleAndCircumference(radius, out double area, out double circumference);

            //calculate the area of circle and circumference of circle using ref keyword
            // you have to initialize the variables before passing them to the method in ref keyword
            double area1 = 0;
            double circumference1 = 0;
            CalculateAreaOfCircleandCircumference(radius, ref area1, ref circumference1);
        }
        public static void CalculateAreaOfCircleAndCircumference(double radius ,out double area , out double circumference)
        {
            area = Math.PI * (radius * radius);
            System.Console.WriteLine("Area of circle is: " + area);
            circumference = 2 * Math.PI * radius;
            System.Console.WriteLine("Circumference of circle is: " + circumference);
        }
        public static void CalculateAreaOfCircleandCircumference(double radius, ref double area1, ref double circumference1)
        {
            area1 = Math.PI * (radius * radius);
            System.Console.WriteLine("Area of circle is: " + area1);
            circumference1 = 2 * Math.PI * radius;
            System.Console.WriteLine("Circumference of circle is: " + circumference1);
        }
    }
}
