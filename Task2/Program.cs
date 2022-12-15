using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int total = 3;
            Person[] persons = new Person[total];

            for (int i = 0; i < total; i++)
            {
                if (i == 0)
                {
                    persons[i] = new Teacher(Console.ReadLine());
                }
                else
                {
                    persons[i] = new Student(Console.ReadLine());
                }
            }

            for (int i = 0; i < total; i++)
            {
                if (i == 0)
                {
                    ((Teacher)persons[i]).Explain();

                }
                else
                {
                    ((Student)persons[i]).Study();
                }
            }

            Console.ReadKey();
        }

        public class Person
        {
            protected string Name { get; set; }

            public Person(string name)
            {
                Name = name;
            }

            public override string ToString()
            {
                return "Hello! My name is " + Name;
            }

            ~Person()
            {
                Name = string.Empty;
            }
        }

        public class Teacher : Person
        {
            public Teacher(string name) : base(name)
            {
                Name = name;
            }

            public void Explain()
            {
                Console.WriteLine("Explaining");
            }
        }

        public class Student : Person
        {
            public Student(string name) : base(name)
            {
                Name = name;
            }

            public void Study()
            {
                Console.WriteLine("Studying");
            }
        }
    }
}
