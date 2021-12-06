using System;
using System.IO;

namespace Lesson_09_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var writer = new StreamWriter(@"C:\programs\example.txt")) 
            {
                writer.WriteLine("HELLO"); 
            }

        }
    }
}
