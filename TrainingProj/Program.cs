using TrainingProj.Models;

namespace TrainingProj
{
    public class Training
    {
        public static void Main(string[] args)
        {
            int total = 3;
            Person[] persons = new Person[total];

            for (int i = 0; i < total; i++)
            {
                if (i == 0)
                {
                    persons[i] = new Employee(Console.ReadLine());
                }
                else
                {
                    persons[i] = new Customer(Console.ReadLine());
                }
            }

            for (int i = 0; i < total; i++)
            {
                if (i == 0)
                {
                    ((Employee)persons[i]).Job();

                }
                else
                {
                    ((Customer)persons[i]).Buy();
                }
            }
        }
    }
}