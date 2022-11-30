namespace IntegerCheck
{
    class IntegerCheck
    {
        public void IsNumber(ref string? item)
        {
            if (long.TryParse(item, out _))
            {
                Console.WriteLine(item + " is a number");
            }
            else
            {
                Console.WriteLine(item + " is not a number");
            }
        }

        public static void Main(String[] args)
        {
            IntegerCheck integerCheck = new();

            try
            {
                string? input;

                Console.WriteLine("Enter the input value : ");

                input = Console.ReadLine();

                integerCheck.IsNumber(ref input);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}