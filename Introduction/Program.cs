using System;

namespace Introduction
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Please enter something: ");

            string str = Console.ReadLine();

            var i = float.Parse(str);

            Console.Write("You entered: ");
            Console.WriteLine(i);

            Console.WriteLine("{0} + {1} = {2}", 3, 5, 3 + 5);
            int x = 6;
            int y = 4;
            Console.WriteLine(y *= 2); // 8
            int z = y = 3; // y=3 and z=3
            Console.WriteLine(z); // 3
            Console.WriteLine(x = x | 1); // 7
            Console.WriteLine(x += 3); // 10
            Console.WriteLine(x /= 2); // 5
        }
    }
}