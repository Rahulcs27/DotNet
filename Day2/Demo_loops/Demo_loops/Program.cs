namespace Demo_loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region loops
            Console.WriteLine("loops");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Value of i: {i}");
            }
            int j = 0;
            while (j < 10)
            {
                Console.WriteLine($"Value of j: {j}");
                j++;
            }
            int k = 0;
            do
            {
                Console.WriteLine($"Value of k: {k}");
                k++;
            } while (k < 10);
            #endregion
            #region jump statements
            string correctPassword = "secure123"; // Set correct password
            int attempts = 0;

        retry:
            if (attempts >= 3)
            {
                Console.WriteLine("Too many failed attempts. Access Denied.");
                return;
            }

            Console.Write("Enter password: ");
            string input = Console.ReadLine();

            if (input == correctPassword)
            {
                Console.WriteLine("Access Granted!");
                return;
            }
            else
            {
                attempts++;
                Console.WriteLine($"Incorrect password. Attempts left: {3 - attempts}");
                goto retry; // Jump back to retry label
            }
            #endregion
            #region Break
            int attempt = 0;
            while (true)
            {
                string correctpassword = "secure123"; // Set correct password
                if(attempt >= 3)
                {
                    Console.WriteLine("Too many failed attempts. Access Denied.");
                    break;
                }
                Console.Write("Enter password: ");
                string password = Console.ReadLine();
                if (password == correctpassword)
                {
                    Console.WriteLine("Access Granted!");
                    break;
                }
                else
                {
                    attempt++;
                    Console.WriteLine($"Incorrect password. Attempts left: {3 - attempt}");
                }
            }
            #endregion
        }
    }
}
