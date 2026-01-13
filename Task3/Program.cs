namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int step = 7;
            int minRange = 5;
            int maxRange = 12233;

            for (int currentNumber = minRange; currentNumber <= maxRange; currentNumber += step)
            {
                Write(currentNumber + " ");
            }
        }
    }
}
