namespace assignment1
{
    internal class program
    {
        static void Main(string[] args)
        {
            # region Scenario1 Student Management System
            Console.WriteLine("Enter Student Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Student Age");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Your Percentage");
            double percentage = double.Parse(Console.ReadLine());
            Console.WriteLine("--Student Details--");
            Console.WriteLine($"Name: {name}\nAge: {age}\nPercentage: {percentage}");
            #endregion

            #region Scenario2 Student Management System
            Console.WriteLine("Enter New Student Name");
            string newname = Console.ReadLine();
            Console.WriteLine("Enter New Student Age");
            int newage;
            bool isAgeValid = int.TryParse(Console.ReadLine(), out newage);
            if (!isAgeValid)
            {
                Console.WriteLine("Invalid Age");
                return;
            }
            Console.WriteLine("\n--- Student Details ---");
            Console.WriteLine($"Name: {newname}");
            Console.WriteLine($"Age: {newage}");
            #endregion

            #region Scenario3 Student Management System
            Console.WriteLine("Enter Student Name");
            string studentName = Console.ReadLine();
            Console.WriteLine("Enter Student Age");
            int age1;
            bool isValid = int.TryParse(Console.ReadLine(), out age1);
            if (!isValid)
            {
                Console.WriteLine("Invalid Age");
                return;
            }
            Console.WriteLine("Enter Email");
            string email = Console.ReadLine();
            if (email == "" || email.Length == 0)
            {
                Console.WriteLine("email field cannot be empty");
                return;
            }
            #endregion

            #region Hospital management system

            Console.WriteLine("Enter Patient Name:");
            string patientName = Console.ReadLine();

            Console.WriteLine("Please enter discharge date of patient: ");
            string? dischargeDate = Console.ReadLine();

            if (dischargeDate?.Length > 0) 
            {
                Console.WriteLine($"Discharge Date is: {dischargeDate}");
            }
            else
            {
                Console.WriteLine("Not Discharged.");
            }
            #endregion
        }
    }
}
