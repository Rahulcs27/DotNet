namespace demo_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Single Dimensional Array
            String[] cities = { "New York", "Paris", "London", "Tokyo" };
            Console.WriteLine($"City :{cities[0]} ");
            foreach (String city in cities)
            {
                Console.WriteLine($"City :{city} ");
            }
            // boxing ---  converting value types to reference types
            int age = 30;
            object newAge = age;

            //unboxing --- reference to value types
            object mark = 100;
            int total = (int)mark;
            Console.WriteLine($"Total :{total} ");
            object[] array = { 100, "Hello", 3.14, true };
            foreach (object obj in array)
            {
                Console.WriteLine($"Object :{obj} ");
            }

            //Array functions
            int[] numbers = { 41, 32, 53, 24, 65 };
            Console.WriteLine("Sorting Array: ");
            Array.Sort(numbers);
            foreach (int number in numbers) { 
                Console.WriteLine($"Number :{number}");
            }
            Array.Reverse(numbers);
            //find city named chennai name in array
            Console.WriteLine("Search city in arrray");
            string cityToFind = Console.ReadLine();
           string Result = Array.Find(cities, city => city == cityToFind);
            if(Result != null)
            {
                Console.WriteLine($"City Found :{Result}");
            }
            else
            {
                Console.WriteLine("City not found");
            }
            #endregion
            #region Multi Dimensional Array
            int[,] matrix = new int[3, 3];
            int[,] matrix1 = new int[2, 2] 
            {
                { 1, 10 },
                { 2 , 20 }
            };
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                if (matrix1[i, 0] == 1) {
                    Console.WriteLine(matrix1[i,1]);
                }
                else
                {
                    Console.WriteLine("");
                }
            }
            #endregion
        }
    }
}
