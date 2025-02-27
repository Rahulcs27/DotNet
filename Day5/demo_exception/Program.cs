namespace demo_exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 15;

            try
            {
                if (age < 18)
                {
                    throw new Exception("Age should be above than 18");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Finally block");
            }
        }

    }
}
