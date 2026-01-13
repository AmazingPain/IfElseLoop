namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isWork = true;

            while (isWork)
            {
                string userInput;
                WriteLine("Enter the word 'exit', to close the programm");

                userInput = ReadLine();
                if (userInput == "exit")
                {
                    isWork = false;
                }
                else
                {
                    WriteLine("Try another one");
                }
            }
        }
    }
}
