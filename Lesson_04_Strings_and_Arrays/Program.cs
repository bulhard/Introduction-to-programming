using System;

namespace Lesson_04_Strings_and_Arrays
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            MainMenu();
        }

        private static void MainMenu()
        {
            string menuOption;
            do
            {
                // Display the menu
                Console.Clear();

                Console.WriteLine(
                "===========\n" +
                "MAIN MENU! \n" +
                "===========\n" +
                "1. Check For Number\n" +
                "2. Reverse an Array\n" +
                "3. Concatenate Arrays\n" +
                "4. Hacker Speak Encoding\n" +
                "===========\n" +
                "0. Exit    \n" +
                "===========\n");

                // Ask user for some input
                Console.Write("Please enter your choice: ");
                menuOption = Console.ReadLine();

                // Analize user input and perform some action
                switch (menuOption)
                {
                    case "1":
                        CheckForNumber();
                        break;

                    case "2":
                        ReverseArray();
                        break;

                    case "3":
                        ConcatArraysDemo();
                        break;

                    case "4":
                        HackerSpeak();
                        break;
                }
            } while (menuOption != "0");
        }

        private static void HackerSpeak()
        {
            // 1. Input
            string original = "HACKER Speak Encoded";

            // 2. Logic
            string encoded = EncodeAsHacker(original);

            // 3. Output
            Console.Clear();

            Console.WriteLine($"Original text: {original}");
            Console.WriteLine($"Encoded text: {encoded}");

            Console.WriteLine("Press any key to continue ...");
            Console.ReadKey();
        }

        private static string EncodeAsHacker(string original)
        {
            original = original.Replace("a", "4");
            original = original.Replace("A", "4");
            original = original.Replace("e", "3");
            original = original.Replace("E", "3");
            original = original.Replace("i", "1");
            original = original.Replace("I", "1");
            original = original.Replace("o", "0");
            original = original.Replace("O", "0");
            original = original.Replace("s", "5");
            original = original.Replace("S", "5");

            return original;
        }

        private static void CheckForNumber()
        {
            // 1. Define array and add some data
            int[] numbers = { 23, 2, 3, 6, 32, 65, 33, 45, 343, 34, 87, 99 };

            // 2. Ask user for a number
            Console.Clear();
            Console.Write("Please enter your a number: ");
            int userNumber = int.Parse(Console.ReadLine());

            // 3. Check if number is in array
            bool isInArray = false;
            foreach (int number in numbers)
            {
                if (number == userNumber)
                {
                    isInArray = true;
                }
            }

            // 4. Display result
            if (isInArray)
            {
                Console.WriteLine($"The number {userNumber} is in the array!");
            }
            else
            {
                Console.WriteLine($"The number {userNumber} is NOT in the array!");
            }

            Console.WriteLine("Press any key to continue ...");
            Console.ReadKey();
        }

        private static void ReverseArray()
        {
            // 1. Define array and add some data
            int[] numbers = { 23, 2, 3, 6, 32, 65, 33, 45, 343, 34, 87, 99 };

            // 2. Swap first and last element
            for (int i = 0; i < numbers.Length / 2; i++)
            {
                int temp = numbers[i];
                numbers[i] = numbers[numbers.Length - 1 - i];
                numbers[numbers.Length - 1 - i] = temp;
            }
        }

        private static string ArrayToString(int[] array)
        {
            string arrayAsText = string.Join(',', array);
            return arrayAsText;
        }

        private static void ConcatArraysDemo()
        {
            int[] first = { 1, 2, 3 };
            int[] second = { 4, 5, 6, 7, 8 };

            var result = ConcatArrays(first, second);

            // Display result
            Console.Clear();

            Console.WriteLine($"First  array: {ArrayToString(first)}");
            Console.WriteLine($"Second array: {ArrayToString(second)}");
            Console.WriteLine($"Result array: {ArrayToString(result)}");

            Console.WriteLine("Press any key to continue ...");
            Console.ReadKey();
        }

        private static int[] ConcatArrays(int[] firstArray, int[] secondArray)
        {
            int totalLength = firstArray.Length + secondArray.Length;

            int[] resutlArray = new int[totalLength];

            int index = 0;

            foreach (int item in firstArray)
            {
                resutlArray[index] = item;
                index++;
            }

            foreach (int item in secondArray)
            {
                resutlArray[index] = item;
                index++;
            }

            return resutlArray;
        }
    }
}