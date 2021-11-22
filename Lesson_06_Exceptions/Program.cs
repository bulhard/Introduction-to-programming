using System;

namespace Lesson_06_Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Person person = new Person("", 21, "");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
