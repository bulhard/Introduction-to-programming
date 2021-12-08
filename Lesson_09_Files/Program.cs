using Lesson_09_Files.Helpers;
using System;
using System.IO;
using System.Linq;

namespace Lesson_09_Files
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter working folder:");
            string workingFolder = Console.ReadLine(); // Copy/paste some existing folder, as there is no check if that folder exists.

            //TestFileHelper(workingFolder);

            //NumberOfWords(workingFolder);

            //TestArrayHelper(workingFolder);

            Exercise2.ProcessStudents(workingFolder);
        }

        private static void TestFileHelper(string workingFolder)
        {
            string fileName = Path.Combine(workingFolder, "test.txt");
            string fileContent = "Hello world\n";
            string moreContent = "Something more to say";

            FileHelper.CreateTextFile(fileName, fileContent);

            FileHelper.AppendTextToFile(fileName, moreContent);

            string content = FileHelper.ReadTextFromFile(fileName);

            Console.WriteLine(content);

            FileHelper.DeleteFile(fileName);
        }

        private static void NumberOfWords(string workingFolder)
        {
            string fileName = Path.Combine(workingFolder, "words_counter.txt");
            string fileContent = "Hello world\n";
            string moreContent = "Something   more to say. What a beatiful day.";

            FileHelper.CreateTextFile(fileName, fileContent);

            FileHelper.AppendTextToFile(fileName, moreContent);

            string content = FileHelper.ReadTextFromFile(fileName);

            Console.WriteLine(content);

            // Split file content by special character to keep only words.
            var words = content.Split(" .,!?@$#%^&*()_-+=\n".ToCharArray());

            var wordsCount = words.Where(w => w.Length > 1).Count();

            Console.WriteLine($"Number of words: {wordsCount}");

            FileHelper.DeleteFile(fileName);
        }

        private static void TestArrayHelper(string workingFolder)
        {
            string fileName = Path.Combine(workingFolder, "array_test.txt");

            int[] arrayOfIntegers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 123, 123, 123, 123, 324, 25536, 3, 564, 3243, 24, 1235, 3425, 24, 234, 24, 243, 23 };

            ArrayHelper.SaveArrayToFile(fileName, arrayOfIntegers);

            var arrayFromFile = ArrayHelper.ReadArrayFromFile(fileName);

            var arrayAsString = string.Join(",", arrayFromFile);

            Console.WriteLine(arrayAsString);

            FileHelper.DeleteFile(fileName);
        }
    }
}