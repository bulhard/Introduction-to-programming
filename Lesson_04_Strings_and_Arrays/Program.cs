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
                Console.Clear();

                Console.WriteLine(
                "===========\n" +
                "MAIN MENU! \n" +
                "===========\n" +
                "1. Option 1\n" +
                "2. Option 2\n" +
                "3. Option 3\n" +
                "4. Option 4\n" +
                "===========\n" +
                "0. Exit    \n" +
                "===========\n");

                Console.Write("Please enter your choice: ");
                menuOption = Console.ReadLine();

                switch (menuOption)
                {
                    case "1":
                        break;

                    case "2":
                        break;

                    case "3":
                        break;

                    case "4":
                        break;
                }
            } while (menuOption != "0");
        }
    }
}