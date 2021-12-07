using System;
using System.IO;

namespace Lesson_09_Files.Helpers
{
    /// <summary>
    /// Static file helper class to demonstrate some functions to work with files.
    /// </summary>
    public static class FileHelper
    {
        public static void CreateTextFile(string fileName, string fileContent)
        {
            if (FileExists(fileName))
            {
                File.Delete(fileName);
            }

            File.WriteAllText(fileName, fileContent);
        }

        public static void AppendTextToFile(string fileName, string textContent)
        {
            if (!FileExists(fileName))
            {
                throw new Exception($"File {fileName} does not exists.");
            }
            else
            {
                File.AppendAllText(fileName, textContent);
            }
        }

        public static bool FileExists(string fileName)
        {
            return File.Exists(fileName);
        }

        public static void DeleteFile(string fileName)
        {
            File.Delete(fileName);
        }

        public static string ReadTextFromFile(string fileName)
        {
            if (!FileExists(fileName))
            {
                return null; // or exception
            }
            else
            {
                return File.ReadAllText(fileName);
            }
        }
    }
}