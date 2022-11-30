namespace EvenNumber
{
    class EvenNumber
    {
        public void fEvenNo(ref List<long?> ilist)
        {
            foreach (var number in ilist)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine(number + " is Even");
                }
                else
                {
                    Console.WriteLine(number + " is Odd");
                }
            }
        }
        public static void Main(string[] args)
        {
            List<long?> lNos = new List<long?>(new long?[10]);

            EvenNumber evenNumber = new();

            try
            {
                Console.WriteLine("Enter 10 numbers : \n");

                for (int i = 0; i < 10; i++)
                {
                    lNos[i] = Convert.ToInt64(Console.ReadLine());
                }

                evenNumber.fEvenNo(ref lNos);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}