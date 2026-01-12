namespace Task8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string userPassword = "123";
            string secretMessage = "Ставка цб 16%";
            string userInput = "";

            int tryCounter = 3;

            WriteLine("Введите пароль для доступа к секретному сообщению");
            while (tryCounter > 0)
            {

                userInput = ReadLine();
                if (userInput == userPassword)
                {
                    WriteLine(secretMessage);
                    break;
                }
                else
                {
                    tryCounter--;
                    WriteLine($"Неверный пароль, попробуйте снова. У вас осталось {tryCounter} попыток(ки)");
                }
            }
            if (userInput != userPassword)
            {
                WriteLine("Доступ заблокирован. Попытки исчерпаны.");
            }
        }
    }
}
