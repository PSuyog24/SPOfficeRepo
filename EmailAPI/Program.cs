
namespace FindProducts
{
    class Product
    {
        public double FindProduct(ref List<double> listOfNos)
        {
            double sum = 0;

            for(int i=1; i<= listOfNos[1]; i++)
            {
                sum += listOfNos[0];
            }

            return sum;
        }

        public static void Main(String[] args)
        {
            Product product = new Product();

            List<double> lNos = new List<double>(new double[2]);

            Console.WriteLine("Enter an integer : ");

            lNos[0] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("By times : ");

            lNos[1] = Convert.ToDouble(Console.ReadLine());

            double result = product.FindProduct(ref lNos);

            Console.WriteLine("The Product is : " + result);
        }
    }
}