using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Class1
    {
        public void Diapozon()
        {
            while (true)
            {
                Clear();
                int limit1;
                int limit2;
                int countEven = 0;
                int countUneven = 0;
                int countSum = 0;
                int sumLimit = 0;
                try
                {
                    Write("Введите первое число для обозначения диапозона: ");
                    limit1 = int.Parse(ReadLine());
                    Write("Введите второе число для обозначения диапозона: ");
                    limit2 = int.Parse(ReadLine());
                }
                catch (Exception)
                {
                    WriteLine("Неудалось считать данные с ввода (неправильный формат ввода)");
                    ReadLine();
                    continue;
                }
                WriteLine($"Диапозон равен {limit1} - {limit2}");
                while (limit1 <= limit2)
                {
                    if (limit1 % 2 == 0)
                    {
                        ++countEven;

                    }
                    else
                    {
                        ++countUneven;
                    }
                    limit1++;
                    countSum = countEven + countUneven;
                    sumLimit += limit1;
                }

                WriteLine($"Кол-во четных чисел = {countEven}");
                WriteLine($"Кол-во нечетных чисел = {countUneven}");
                WriteLine($"Сумма четных и нечетных чисел = {countSum}");
                WriteLine($"Сумма значений четных и нечетных чисел = {sumLimit}");
                ReadLine();
            }
        }
    }
}
