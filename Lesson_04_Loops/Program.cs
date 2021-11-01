using System;
using System.Numerics;

namespace Lesson_04_Loops
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Sum_1_N();
            // Factoriel_01();
            // TenNumbers();
            // Piramide();
            // Factoriel_02();
            // Ninetything();
            Diamond();
        }

        private static void Diamond()
        {
            int i, j, n;

            Console.Write("\n\n");
            Console.Write(" Display the pattern in which first and last number of each row will be 1:\n");
            Console.Write("----------------------------------------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input number of rows : ");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i <= n; i++)
            {
                /* print blank spaces */
                for (j = 1; j <= n - i; j++)
                    Console.Write(" ");
                /* Display number in ascending order upto middle*/
                for (j = 1; j <= i; j++)
                    Console.Write("{0}", j);

                /* Display  number in reverse order after middle */
                for (j = i - 1; j >= 1; j--)
                    Console.Write("{0}", j);

                Console.Write("\n");
            }

            for (i = n - 1; i >= 0; i--)
            {
                /* print blank spaces */
                for (j = 1; j <= n - i; j++)
                    Console.Write(" ");
                /* Display number in ascending order upto middle*/
                for (j = 1; j <= i; j++)
                    Console.Write("{0}", j);

                /* Display  number in reverse order after middle */
                for (j = i - 1; j >= 1; j--)
                    Console.Write("{0}", j);

                Console.Write("\n");
            }
        }

        private static void Diamond2()
        {
            int i, j, r;

            Console.Write("\n\n");
            Console.Write("Display the pattern like diamond:\n");
            Console.Write("-----------------------------------");
            Console.Write("\n\n");

            Console.Write("Input number of rows (half of the diamond) :");
            r = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i <= r; i++)
            {
                for (j = 1; j <= r - i; j++)
                    Console.Write(" ");
                for (j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.Write("\n");
            }

            for (i = r - 1; i >= 1; i--)
            {
                for (j = 1; j <= r - i; j++)
                    Console.Write(" ");
                for (j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.Write("\n");
            }
        }

        private static void Ninetything()
        {
            // 9 + 99 + 999
            int n = int.Parse(Console.ReadLine());

            int sum = 9;
            Console.Write("Sum of 9");

            for (int i = 2; i <= n; i++)
            {
                string sn = "";
                for (int j = 1; j <= i; j++)
                {
                    sn = sn + "9";
                }

                Console.Write(" + " + sn);

                sum = sum + int.Parse(sn);
            }

            Console.WriteLine(" = " + sum);
        }

        private static void Factoriel_02()
        {
            int n = int.Parse(Console.ReadLine());

            // 0! = 1
            // n! = 1 * 2 * 3 .... * n

            BigInteger factoriel = 1;

            for (int counter = 1; counter <= n; counter++)
            {
                factoriel = factoriel * counter;
            }

            Console.WriteLine($"{n}! = {factoriel}");
        }

        private static void TenNumbers()
        {
            int sum = 0;
            float avg = 0;
            for (int counter = 1; counter <= 10; counter++)
            {
                Console.Write($"Number {counter}: ");
                int userInput = int.Parse(Console.ReadLine());
                sum = sum + userInput;
            }
            avg = (float)sum / 10;

            Console.WriteLine($"Sum={sum} Average={avg}");
        }

        private static void Piramide()
        {
            int n = int.Parse(Console.ReadLine());
            for (int row = 1; row <= n; row = row + 1)
            {
                for (int s = 1; s < n + 1 - row; s++)
                {
                    Console.Write(" ");
                }

                for (int column = 1; column <= row; column = column + 1)
                {
                    // Console.Write("{0} ", column);
                    Console.Write("{0} ", "*");
                }

                Console.WriteLine();
            }
        }

        private static void Triangle()
        {
            int n = int.Parse(Console.ReadLine());
            for (int row = 1; row <= n; row = row + 1)
            {
                for (int column = 1; column <= row; column = column + 1)
                {
                    Console.Write("{0} ", column);
                    // Console.Write("{0} ", "*");
                }

                Console.WriteLine();
            }
        }

        private static void Factoriel_01()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            // Calculate n! = 1 * 2 * ... * n
            BigInteger result = 1;
            while (true)
            {
                if (n == 1)
                    break;
                result = result * n;
                n--;
            }
            Console.WriteLine("n! = " + result);
        }

        private static void Sum_1_N()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int number = 1;
            int sum = 1;
            Console.Write("The sum 1");
            while (number < n)
            {
                number = number + 1;
                sum = sum + number;

                Console.Write("+{0}", number);
            }
            Console.WriteLine(" = {0}", sum);
        }
    }
}