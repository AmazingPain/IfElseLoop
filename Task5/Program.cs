namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            const string SHOW_TEXT = "1";
            const string SHOW_RANDOM_NUMBER = "2";
            const string CLEAR_CONSOLE = "3";
            const string EXIT = "4";

            int startNumberRange = 1;
            int endNumberRange = 101;

            bool isWork = true;

            WriteLine("Добро пожаловать в бессмысленную программу!");
            WriteLine("-----------------------------------------------------------------------");
            WriteLine("На выбор у Вас есть четыре бесполезные команды. Выберите одну из них.");

            while (isWork)
            {
                WriteLine($"Введите цифру {SHOW_TEXT} что бы вывести бессмысленный текст.");
                WriteLine($"Введите цифру {SHOW_RANDOM_NUMBER} что бы показать случайное число.");
                WriteLine($"Введите цифру {CLEAR_CONSOLE} что бы очистить консоль.");
                WriteLine($"Введите цифру {EXIT} что бы выйти.");
                Write("Ваш ввод: ");
                string userInput = ReadLine();

                WriteLine();

                switch (userInput)
                {
                    case SHOW_TEXT:
                        WriteLine("Бессмысленный текст");
                        break;
                    case SHOW_RANDOM_NUMBER:
                        WriteLine($"Показываю случайное число от 0 до 100: {random.Next(startNumberRange, endNumberRange)}");
                        break;
                    case CLEAR_CONSOLE:
                        WriteLine("Очищаю консоль, подождите...");
                        Clear();
                        break;
                    case EXIT:
                        WriteLine("Выход из программы.");
                        isWork = false;
                        break;
                    default:
                        WriteLine("Неизвестная программа, попробуйте заново.");
                        break;
                }
            }

            ReadKey();
        }
    }
}
