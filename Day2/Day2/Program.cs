namespace Day2
{
    internal class Program
    {
        static void Main(string[] args)
        {   double cartValue;
            double discount = 0;
            Console.WriteLine("Enter Cart Value");
            cartValue = Convert.ToDouble(Console.ReadLine());
            if (cartValue >= 5000)
            {
                discount = cartValue * 0.20; // 20% Discount if above 5000
            }
            else if (cartValue >= 3000) {
                discount = cartValue * 0.10; // 10% Discount if above 3000 and below 5000
            }
            double amt2Pay = cartValue - discount;
            Console.WriteLine($"Total Cart Amount: {cartValue}");
            Console.WriteLine($"Discount Applied: {discount}");
            Console.WriteLine($"Amount to Pay: {amt2Pay}");

            //if (cartValue >= 3000)
            //{
            //    Console.WriteLine("Free shipping is available");
            //}
            //else
            //{
            //    Console.WriteLine("Pay Rs. 50 for shipping.");
            //}
            Console.WriteLine($"Shipping: {(cartValue >= 3000 ? "free" : "Rs. 50")}"); // Ternary Operators

        }
    }
}
