using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_06_Exceptions
{
    /// <summary>
    /// This is a person class
    /// </summary>
    public class Person
    {
        public Person(string name, int age, string email)
        {
            Name = name;
            Age = age;
            if (string.IsNullOrEmpty(email))
            {
                Email = "sample@apple.com";
            }
            else
            {
                Email = email;
            }
        }

        public Person(string name, int age) : this(name, age, null)
        {

        }

        public override string ToString()
        {
            return $"Person {name} is {age} year old and has email {email}";
        }

        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Invalid name!");
                }

                name = value;
            }
        }

        private int age;
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentOutOfRangeException("Age should be between 1 and 100");
                }
                age = value;
            }
        }

        private string email;
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                if (value == null || value.Contains("@"))
                {
                    email = value;
                }
                else
                {
                    throw new ArgumentException("Invalid e-mail value.");
                }
            }
        }
    }
}
