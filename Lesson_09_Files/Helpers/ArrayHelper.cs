using System.IO;
using System.Linq;
using System.Text;

namespace Lesson_09_Files.Helpers
{
    /// <summary>
    /// Static class to demostrate how to write array of integer to file and read it back from file
    /// </summary>
    public static class ArrayHelper
    {
        public static void SaveArrayToFile(string fileName, int[] arrayOfIntegers)
        {
            StringBuilder builder = new StringBuilder();

            foreach (int nextItem in arrayOfIntegers)
            {
                builder.AppendLine(nextItem.ToString());
            }

            FileHelper.CreateTextFile(fileName, builder.ToString());
        }

        public static int[] ReadArrayFromFile(string fileName)
        {
            try
            {
                var lines = File.ReadAllLines(fileName);

                var arrayOfIntegers = new int[lines.Count()];

                int i = 0;

                foreach (var line in lines)
                {
                    if (int.TryParse(line, out int parsedValue))
                    {
                        arrayOfIntegers[i] = parsedValue;
                        i++;
                    }
                }

                return arrayOfIntegers;
            }
            catch
            {
                return null;
            }
        }
    }
}