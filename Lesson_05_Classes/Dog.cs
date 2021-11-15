using System;

namespace Lesson_05_Classes
{
    public class Dog
    {
        public string Name { get; set; }

        public string Breed { get; set; }

        public void Bark()
        {
            Console.WriteLine("Woof, Woof");
        }
    }
}
