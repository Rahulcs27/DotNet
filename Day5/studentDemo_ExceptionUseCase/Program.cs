using studentDemo_ExceptionUseCase.Model;
using studentDemo_ExceptionUseCase.Repository;

namespace studentDemo_ExceptionUseCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentRepository studentRepo = new StudentRepository();

            while (true)
            {
                Console.WriteLine("\nDo you want to add a new student? (yes/no): ");
                string choice = Console.ReadLine().Trim().ToLower();

                if (choice == "no")
                    break;

                // Take Student ID input
                Console.Write("Enter Student ID: ");
                int id;
                while (!int.TryParse(Console.ReadLine(), out id)) // Ensures ID is a number
                {
                    Console.Write("Invalid input! Enter a numeric Student ID: ");
                }

                // Take Student Name input
                Console.Write("Enter Student Name: ");
                string name = Console.ReadLine().Trim();

                // Add student to repository
                bool isAdded = studentRepo.AddStudent(new Student(id, name));

                // Feedback to user
                if (isAdded)
                {
                    Console.WriteLine($"Student '{name}' added successfully!");
                }
                else
                {
                    Console.WriteLine($"Failed to add student '{name}'.");
                }
            }

            // Display all students
            Console.WriteLine("\nFinal Student List:");
            foreach (var student in studentRepo.GetStudents())
            {
                Console.WriteLine($"ID: {student.Id}, Name: {student.Name}");
            }





        }
    }
}
