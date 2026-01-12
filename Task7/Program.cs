using System.Text;

namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder stringBuilder = new StringBuilder();

            string userName;
            string userDigit;
            string border;
            string middleLine;
            int widthUserName;

            
            Write("Введите имя пользователя: ");
            userName = ReadLine();
            Write("Введите символ, из которого будет состоять прямоугольник: ");
            userDigit = ReadLine();

            widthUserName = userName.Length + 2;

            for (int i = 0; i < widthUserName; i++)
            {
                stringBuilder.Append(userDigit);
            }
            border = stringBuilder.ToString();
            stringBuilder.Clear();
            stringBuilder.Append(userDigit);
            stringBuilder.Append(userName);
            stringBuilder.Append(userDigit);
            middleLine = stringBuilder.ToString();
            WriteLine(border);
            WriteLine(middleLine);
            WriteLine(border);

        }
    }
}
