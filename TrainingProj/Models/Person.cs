using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProj.Models
{
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

    public class Employee : Person
    {
        public Employee(string name) : base(name)
        {
            Name = name;
        }

        public void Job()
        {
            Console.WriteLine("Job");
        }
    }

    public class Customer : Person
    {
        public Customer(string name) : base(name)
        {
            Name = name;
        }

        public void Buy()
        {
            Console.WriteLine("Buy");
        }
    }
}
