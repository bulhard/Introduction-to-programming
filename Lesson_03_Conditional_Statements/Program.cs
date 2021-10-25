using System;

namespace Lesson_03_Conditional_Statements
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Triangles();
            //Numbers();
            SportSelector();
        }

        private static void SportSelector()
        {
            Console.Write("Please enter your height in centimeters: ");
            int height = int.Parse(Console.ReadLine());

            if (height > 190)
            {
                Console.WriteLine("Basketball");
            }
            else if (height > 175)
            {
                Console.WriteLine("Atletics");
            }
            else
            {
                Console.WriteLine("Horse riding");
            }
        }

        private static void Numbers()
        {
            Console.Write("Number 1: ");
            int A01 = int.Parse(Console.ReadLine());

            Console.Write("Number 2: ");
            int A02 = int.Parse(Console.ReadLine());

            Console.Write("Number 3: ");
            int A03 = int.Parse(Console.ReadLine());

            Console.Write("Number 4: ");
            int A04 = int.Parse(Console.ReadLine());

            Console.Write("Number 5: ");
            int A05 = int.Parse(Console.ReadLine());

            Console.Write("Number 6: ");
            int A06 = int.Parse(Console.ReadLine());

            Console.Write("Number 7: ");
            int A07 = int.Parse(Console.ReadLine());

            Console.Write("Number 8: ");
            int A08 = int.Parse(Console.ReadLine());

            Console.Write("Number 9: ");
            int A09 = int.Parse(Console.ReadLine());

            Console.Write("Number 10: ");
            int A10 = int.Parse(Console.ReadLine());

            long sum = 0;
            int count = 0;

            if (10 <= A01 && A01 <= 20)
            {
                count++;
                sum = sum + A01;
            }

            if (10 <= A02 && A02 <= 20)
            {
                count++;
                sum = sum + A02;
            }

            if (10 <= A03 && A03 <= 20)
            {
                count++;
                sum = sum + A03;
            }

            if (10 <= A04 && A04 <= 20)
            {
                count++;
                sum = sum + A04;
            }

            if (10 <= A05 && A05 <= 20)
            {
                count++;
                sum = sum + A05;
            }

            if (10 <= A06 && A06 <= 20)
            {
                count++;
                sum = sum + A06;
            }

            if (10 <= A07 && A07 <= 20)
            {
                count++;
                sum = sum + A07;
            }

            if (10 <= A08 && A08 <= 20)
            {
                count++;
                sum = sum + A08;
            }

            if (10 <= A09 && A09 <= 20)
            {
                count++;
                sum = sum + A09;
            }

            if (10 <= A10 && A10 <= 20)
            {
                count++;
                sum = sum + A10;
            }

            Console.WriteLine("Count of numbers between 10 and 20 is: " + count);
            Console.WriteLine("Sum of numbers between 10 and 20 is: " + sum);
        }

        private static void Triangles()
        {
            Console.Write("Side A: ");
            int A = int.Parse(Console.ReadLine());

            Console.Write("Side B: ");
            int B = int.Parse(Console.ReadLine());

            Console.Write("Side C: ");
            int C = int.Parse(Console.ReadLine());

            if (A == B || B == C || A == C)
            {
                Console.WriteLine("There are 2 equal sides.");
            }
            else
            {
                Console.WriteLine("There are NO equal sides.");
            }

            if (A == B && B == C)
            {
                Console.WriteLine("There are 3 equal sides.");
                Console.WriteLine("A, B and C are equal.");
            }
            else if (A == B)
            {
                Console.WriteLine("A and B are equal.");
            }
            else if (B == C)
            {
                Console.WriteLine("B and C are equal.");
            }
            else if (A == C)
            {
                Console.WriteLine("A and C are equal.");
            }
        }
    }
}