namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int currentNumber;
            int step = 7;
            int minRange = 5;
            int maxRange = 12233;
            for (currentNumber = minRange; currentNumber <= maxRange; currentNumber += step)
            {
                Write(currentNumber + " ");
            }
        }
    }
}
