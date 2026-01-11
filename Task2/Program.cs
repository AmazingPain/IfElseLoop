namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string userInput;
            while(true)
            {
                WriteLine("Enter the word 'exit', to close the programm");
                userInput = ReadLine();
                if (userInput == "exit")
                {
                    break;
                }
                else
                {
                    WriteLine("Try another one");
                }
            }
            WriteLine("1");
            Thread.Sleep(1000);
            WriteLine("2");
            Thread.Sleep(1000);
            WriteLine("3");
            Thread.Sleep(1000);
            WriteLine("Close...");
        }
    }
}
