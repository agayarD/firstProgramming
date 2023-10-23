namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            int var1;

            try
            {
               var1 = int.Parse(Console.ReadLine());
            }
            catch(Exception exc)
            {
                Console.WriteLine("you can only enter int number");
                var1 = 0;
            }
           

            Console.WriteLine("Enter second number");
            int var2 = int.Parse(Console.ReadLine());

            int sum = Sum(var1,var2);

            Console.WriteLine("Sum is: " + sum);

        }

        public static int Sum(int var1, int var2)
        {
            return var1 + var2;
        }
    }
}