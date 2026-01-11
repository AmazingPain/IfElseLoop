using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal class Class1
    {
        internal class CurrencyConverter
        {
            private const double dollar = 78.3;
            private const double euro = 92.3;
            private double result = 0;
            public double Convert(double rubles)
            {
                result = rubles / dollar;
                WriteLine($"Курс доллара - {dollar}");
                WriteLine($"Сумма в долларах - {result}");
                return result;
            }
            public double Convert(double rubles, string toCurrency = "dlr", double exchangeRate = dollar)
            {
                result = 0;
                if (toCurrency == "dlr")
                {
                    result = rubles / exchangeRate;
                    WriteLine($"Курс доллара - {exchangeRate}");
                    WriteLine($"Сумма в долларах - {result}");
                }
                else if (toCurrency == "eu")
                {
                    exchangeRate = euro;
                    result = rubles / exchangeRate;
                    WriteLine($"Курс евро - {exchangeRate}");
                    WriteLine($"Сумма в евро - {result}");
                }
                else
                {
                    WriteLine("Неизвестная валюта");
                }
                return result;
            }
        }
    }
}
