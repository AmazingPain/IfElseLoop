namespace Task10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int genericNumber = random.Next(10, 33);
            int degreeTwo = 2;
            int resultDegree = 1;
            int countDegree = 0;


            while (resultDegree <= genericNumber)
            {
                resultDegree *= degreeTwo;
                countDegree++;
            }
            WriteLine($"Заданное число {genericNumber}, минимальая степень 2 превосходящее число {countDegree} , число превосходящее заданное число {resultDegree}");
        }
    }
}
