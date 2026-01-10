namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Write("Введите фразу для вывода в консоль: ");
            string? userInput = ReadLine();
            WriteLine();
            Write("Введите кол-во повторений цикла: ");
            int count = int.Parse(ReadLine());

            for (int i = 0; i < count; i++)
            {
                Write(userInput);
            }
        }
    }
}
