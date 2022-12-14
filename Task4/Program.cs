namespace Task4
{
    public class Task
    {
        public static void Main(String[] args)
        {
            Dog dog = new Dog();
            Console.WriteLine("Enter your dog's name : ");
            dog.SetName(Console.ReadLine());
            Console.WriteLine(dog.GetName());
            dog.Eat();
        }
    }

    public class Dog : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("is Eating");
        }
    }

    public abstract class Animal
    {
        private string? Name;

        public void SetName(string name)
        {
            Name = name;
        }

        public string? GetName()
        {
            return Name;
        }

        public abstract void Eat();
    }
}