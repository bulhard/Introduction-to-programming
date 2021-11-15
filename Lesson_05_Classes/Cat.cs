using Lesson_05_Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cats
{
    public class Cat : Animal
    {
        private string name;

        public static bool IsItAnimal()
        {
            return true;
        }

        public Cat(string name, string owner)
        {
            this.name = name;
            this.Owner = owner;
        }

        public Cat(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string Owner
        {
            get;
            set;
        }

        public static int Age
        {
            get;
            set;
        }

        public void SayMiau()
        {
            Console.WriteLine("Miauuuuuuu!");
        }
    }
}
