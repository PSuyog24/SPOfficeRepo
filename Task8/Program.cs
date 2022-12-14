using System.Collections;

namespace Task8
{
    class Task
    {
        public static void Main(String[] args)
        {
            ArrayList arrayList = new ArrayList();

            for(int i=0;i<3;i++)
            {
                string? name = Console.ReadLine();
                int age = int.Parse(Console.ReadLine());

                arrayList.Add(new Person()
                {
                    Name = name,
                    Age = age
                });
            }

            foreach(Person person in arrayList)
            {
                Console.WriteLine(person.ToString());
            }

            Console.ReadKey();
        }
    }
}