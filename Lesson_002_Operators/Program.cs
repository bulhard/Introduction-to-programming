using System;

namespace Lesson_002_Operators
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // AgeAfter10();
            // SimpleFormulas();
            Dates();
        }

        private static void Dates()
        {
            DateTime now = DateTime.Now;

            Console.WriteLine($"Current date is {now.ToString("yyyy-MM-dd")}");

            Console.WriteLine($"Current time is {now.ToString("HH:mm:ss")}");

            Console.Write("Please enter period in years: ");
            int periodInYears = int.Parse(Console.ReadLine());

            DateTime futureDate = DateTime.Now.AddYears(periodInYears);

            Console.WriteLine($"Date after {periodInYears} is {futureDate:yyyy-MM-dd}");
        }

        private static void SimpleFormulas()
        {
            Console.Write("Please enter side A: ");
            var sideA = int.Parse(Console.ReadLine());

            Console.Write("Please enter side B: ");
            var sideB = int.Parse(Console.ReadLine());

            int area = sideA * sideB;
            int perimeter = (sideA + sideB) * 2;

            Console.WriteLine($"Area = {area}");
            Console.WriteLine($"Perimeter = {perimeter}");
        }

        private static void AgeAfter10()
        {
            try
            {
                Console.Write("Please enter your age: ");

                var age = int.Parse(Console.ReadLine());

                var newAge = age + 10;

                Console.WriteLine($"Your age after 10 years will be {newAge}");
            }
            catch
            {
                Console.WriteLine("Bad news. There are arrors in this program.");
            }
        }
    }
}