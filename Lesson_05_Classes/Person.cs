using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_05_Classes
{
    public class Person
    {
        public Person(string name, int age, string email)
        {
            Name = name;
            Age = age;
            Email = email;
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
                    throw new Exception("Invalid name!");
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
                    throw new Exception("Age should be between 1 and 100");
                }
                age = value;
            } 
        }

        private string email;
        public string Email {
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
                    throw new Exception("Invalid e-mail value.");
                }
            }
        }
    }
}
