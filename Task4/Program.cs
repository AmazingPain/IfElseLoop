namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int number = random.Next(1, 101);

            int sumNumbers  = 0;
            for (int i = 1; i <= number; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sumNumbers += i;
                }
            }

            WriteLine($"Number is : {number}");
            WriteLine($"The sum of numbers  of 3 and 5 is: {sumNumbers}");
        }
    }
}
