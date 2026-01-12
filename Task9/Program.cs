namespace Task9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int N = random.Next(10, 26);
            int currentValue = 0;
            int counter = 0;

            while (currentValue < 50)
            {
                currentValue += N;
            }

            for (; 50 <= currentValue && currentValue <= 150; currentValue+=N)
            {
                counter++;
            }
            WriteLine(N);
            WriteLine(counter);
        }
    }
}