using Cats;
using System;

namespace Lesson_05_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Cat area

            //Cat mycat = new Cat("Tom", "Jerry");

            //Cat mySecondCat = new Cat("Maria");

            //Console.Write(mycat.Name);

            //Console.Write(mySecondCat.Name);

            //Cat.Age = 10;

            #endregion

            #region Dog area

            //Dog dog1 = new Dog();

            //dog1.Name = "Dog 1";
            //dog1.Breed = "Breed 1";

            //dog1.Bark();

            //Dog dog2 = new Dog 
            //{ 
            //    Name = "Dog 2",
            //    Breed = "Breed 2"
            //};

            //dog2.Breed = "Unknown";

            //dog2.Bark();

            #endregion

            Person person1 = new Person("Ivan", 25, "ivan@gmail.com");

            Person person2 = new Person("Maria", 15);

            Console.WriteLine(person1.ToString());

            Console.WriteLine(person2);

            Console.WriteLine(person2.ToString());
        }
    }
}
