namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const float DOLLAR_FACTOR_TO_EURO = 0.8596f;
            const float EURO_FACTOR_TO_DOLLAR = 1.16f;
            const float RUB_FACTOR_TO_DOLLAR = 0.0127f;
            const float RUB_FACTOR_TO_EURO = 0.0108f;
            const float DOLLAR = 78.3f;
            const float EURO = 92.3f;

            const string CONVERT_RUB_TO_DOLLAR = "1";
            const string CONVERT_RUB_TO_EURO = "2";
            const string CONVERT_DOLLAR_TO_EURO = "3";
            const string CONVERT_EURO_TO_DOLLAR = "4";
            const string CONVERT_DOLLAR_TO_RUB = "5";
            const string CONVERT_EURO_TO_RUB = "6";
            const string WALLET = "7";
            const string CLEAR_CONSOLE = "8";
            const string EXIT = "9";

            float dollarInWallet;
            float euroInWallet;
            float rubInWallet;

            bool isWork = true;

            string userInput;
            float userCurrency;


            WriteLine("Добро пожаловать в конвертер валют!");
            WriteLine("----------------------------------------------------------------------------");
            WriteLine("Курс валют на данный момент");
            WriteLine($"Курс доллара к рублю - {DOLLAR} рублей за 1 доллар");
            WriteLine($"Курс евро к рублю - {EURO} рублей за 1 евро");
            WriteLine($"Курс доллара к евро - {DOLLAR_FACTOR_TO_EURO} доллара за 1 евро");
            WriteLine($"Курс евро к доллару - {EURO_FACTOR_TO_DOLLAR} евро за 1 доллар");
            WriteLine($"Курс доллара к рублю - {RUB_FACTOR_TO_DOLLAR} доллара за 1 рубль");
            WriteLine($"Курс евро к рублю - {RUB_FACTOR_TO_EURO} евро за 1 рубль");
            WriteLine("----------------------------------------------------------------------------");

            Write("Введите кол-во долларов в вашем кошельке: ");
            dollarInWallet = float.Parse(ReadLine());
            Write("Введите кол-во евро в вашем кошельке: ");
            euroInWallet = float.Parse(ReadLine());
            Write("Введите кол-во рублей в вашем кошельке: ");
            rubInWallet = float.Parse(ReadLine());
            WriteLine("----------------------------------------------------------------------------");
            WriteLine("Кол-во валюты в вашем кошельке:");
            WriteLine($"Доллары: {dollarInWallet}");
            WriteLine($"Евро: {euroInWallet}");
            WriteLine($"Рубли: {rubInWallet}");
            WriteLine("----------------------------------------------------------------------------");

            while (isWork)
            {
                WriteLine($"Введите цифру {CONVERT_RUB_TO_DOLLAR} что бы конвертировать рубли в доллары");
                WriteLine($"Введите цифру {CONVERT_RUB_TO_EURO} что бы конвертировать рубли в евро");
                WriteLine($"Введите цифру {CONVERT_DOLLAR_TO_EURO} что бы конвертировать доллары в евро");
                WriteLine($"Введите цифру {CONVERT_EURO_TO_DOLLAR} что бы конвертировать евро в доллары");
                WriteLine($"Введите цифру {CONVERT_DOLLAR_TO_RUB} что бы конвертировать доллары в рубли");
                WriteLine($"Введите цифру {CONVERT_EURO_TO_RUB} что бы конвертировать евро в рубли");
                WriteLine($"Введите цифру {WALLET} что бы показать доступный баланс");
                WriteLine($"Введите цифру {CLEAR_CONSOLE} что бы очистить консоль.");
                WriteLine($"Введите цифру {EXIT} что бы выйти.");
                WriteLine("----------------------------------------------------------------------------");
                Write("Выберите пункт действий: ");
                userInput = ReadLine();
                WriteLine();
                switch (userInput)
                {
                    case CONVERT_RUB_TO_DOLLAR:
                        Write("Введите кол-во рублей которые хотите обменять на доллары: ");
                        userCurrency = float.Parse(ReadLine());
                        if (userCurrency > 0 && userCurrency <= rubInWallet)
                        {
                            rubInWallet -= userCurrency;
                            dollarInWallet += userCurrency / DOLLAR;
                            WriteLine("Успешная конвертация");
                            WriteLine($"Вы получили {userCurrency / DOLLAR} долларов. На вашем счету {rubInWallet} руб и {dollarInWallet} долларов");
                            WriteLine("----------------------------------------------------------------------------");
                        }
                        else
                        {
                            WriteLine("Ошибка! Сумма должна быть больше нуля и не превышать ваш текущий баланс");
                            WriteLine("----------------------------------------------------------------------------");
                        }

                        break;
                    case CONVERT_RUB_TO_EURO:
                        Write("Введите кол-во рублей которые хотите обменять на евро: ");
                        userCurrency = float.Parse(ReadLine());
                        if (userCurrency > 0 && userCurrency <= rubInWallet)
                        {
                            rubInWallet -= userCurrency;
                            euroInWallet += userCurrency / EURO;
                            WriteLine("Успешная конвертация");
                            WriteLine($"Вы получили {userCurrency / EURO} евро. На вашем счету {rubInWallet} руб и {euroInWallet} евро");
                            WriteLine("----------------------------------------------------------------------------");
                        }
                        else
                        {
                            WriteLine("Ошибка! Сумма должна быть больше нуля и не превышать ваш текущий баланс");
                            WriteLine("----------------------------------------------------------------------------");
                        }


                        break;
                    case CONVERT_DOLLAR_TO_EURO:
                        Write("Введите кол-во долларов которые хотите обменять на евро: ");
                        userCurrency = float.Parse(ReadLine());
                        if (userCurrency > 0 && userCurrency <= dollarInWallet)
                        {
                            dollarInWallet -= userCurrency;
                            euroInWallet += userCurrency * DOLLAR_FACTOR_TO_EURO;
                            WriteLine("Успешная конвертация");
                            WriteLine($"Вы получили {userCurrency * DOLLAR_FACTOR_TO_EURO} евро. На вашем счету {dollarInWallet} долларов и {euroInWallet} евро");
                            WriteLine("----------------------------------------------------------------------------");
                        }
                        else
                        {
                            WriteLine("Ошибка! Сумма должна быть больше нуля и не превышать ваш текущий баланс");
                            WriteLine("----------------------------------------------------------------------------");
                        }

                        break;
                    case CONVERT_EURO_TO_DOLLAR:
                        Write("Введите кол-во евро которые хотите обменять на доллары: ");
                        userCurrency = float.Parse(ReadLine());
                        if (userCurrency > 0 && userCurrency <= euroInWallet)
                        {
                            euroInWallet -= userCurrency;
                            dollarInWallet += userCurrency * EURO_FACTOR_TO_DOLLAR;
                            WriteLine("Успешная конвертация");
                            WriteLine($"Вы получили {userCurrency * EURO_FACTOR_TO_DOLLAR} долларов. На вашем счету {euroInWallet} евро и {dollarInWallet} долларов");
                            WriteLine("----------------------------------------------------------------------------");
                        }
                        else
                        {
                            WriteLine("Ошибка! Сумма должна быть больше нуля и не превышать ваш текущий баланс");
                            WriteLine("----------------------------------------------------------------------------");
                        }

                        break;
                    case CONVERT_DOLLAR_TO_RUB:
                            Write("Введите кол-во долларов которые хотите обменять на рубли: ");
                            userCurrency = float.Parse(ReadLine());
                            if (userCurrency > 0 && userCurrency <= dollarInWallet)
                            {
                                dollarInWallet -= userCurrency;
                                rubInWallet += userCurrency * DOLLAR;
                            WriteLine("Успешная конвертация");
                                WriteLine($"Вы получили {userCurrency * DOLLAR} рублей. На вашем счету {rubInWallet} рублей и {dollarInWallet} долларов");
                                WriteLine("----------------------------------------------------------------------------");
                            }
                            else
                            {
                                WriteLine("Ошибка! Сумма должна быть больше нуля и не превышать ваш текущий баланс");
                                WriteLine("----------------------------------------------------------------------------");
                            }
                        
                        break;
                    case CONVERT_EURO_TO_RUB:
                            Write("Введите кол-во евро которые хотите обменять на рубли: ");
                            userCurrency = float.Parse(ReadLine());
                            if (userCurrency > 0 && userCurrency <= euroInWallet)
                            {
                                euroInWallet -= userCurrency;
                                rubInWallet += userCurrency * EURO;
                                WriteLine("Успешная конвертация");
                                WriteLine($"Вы получили {userCurrency * EURO} рублей. На вашем счету {rubInWallet} рублей и {euroInWallet} евро");
                                WriteLine("----------------------------------------------------------------------------");
                            }
                            else
                            {
                                WriteLine("Ошибка! Сумма должна быть больше нуля и не превышать ваш текущий баланс");
                                WriteLine("----------------------------------------------------------------------------");
                            }
                        
                        break;
                    case WALLET:
                        WriteLine("Кол-во валюты в вашем кошельке:");
                        WriteLine($"Доллары: {dollarInWallet}");
                        WriteLine($"Евро: {euroInWallet}");
                        WriteLine($"Рубли: {rubInWallet}");
                        break;
                    case CLEAR_CONSOLE:
                        WriteLine("Очищаю консоль, подождите...");
                        for (int i = 1; i <= 3; i++)
                        {
                            Thread.Sleep(500);
                            WriteLine(i);
                        }
                        Clear();
                        break;
                    case EXIT:
                        WriteLine("Выход из программы.");
                        isWork = false;
                        break;
                    default:
                        WriteLine("Неверный ввод. Попробуйте снова.");
                        break;
                }
            }
        }
    }
}
