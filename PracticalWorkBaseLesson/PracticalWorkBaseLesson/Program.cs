using System;


namespace PracticalWorkBaseLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.Bычисления значения функции y = 7x ^ 2 - 3x + 4 при любом значении x;
            Random random = new Random();
            int x = random.Next(1, 10);
            int y = 7 * x ^ 2 - 3 * x + 4;
            Console.WriteLine($"При значении x = {x} в функции y = 7x ^ 2 - 3x + 4 , y = {y}");

            // 2.Дан радиус окружности. Найти длину окружности и площадь круга.
            Console.WriteLine("Введите радиус круга");
            double R = double.Parse(Console.ReadLine());
            double pi = 3.14;
            double l = 2 * pi * R;
            double S = pi * R * R;
            Console.WriteLine("Длина окружности = " + l);
            Console.WriteLine("Площадь круга = " + S);

            // 3.Дано расстояние в сантиметрах. Найти число полных метров в нем.
            double distanceCm;
            double distanceMetre;
            Console.WriteLine("Введите растояние (см):");
            distanceCm = double.Parse(Console.ReadLine());
            distanceMetre = distanceCm / 100;
            Console.Write("Растояние в метрах (м) = ");
            Console.WriteLine(distanceMetre);

            // 4.С некоторого момента прошло 234 дня. Сколько полных недель прошло за этот период?
            Console.WriteLine("Введите номер дня недели:");
            Console.WriteLine("1- Понедельник");
            Console.WriteLine("2- Вторник");
            Console.WriteLine("3- Среда");
            Console.WriteLine("4- Четверг");
            Console.WriteLine("5- Пятница");
            Console.WriteLine("6- Суббота");
            Console.WriteLine("7- Воскресение ");
            int numberDayOfWeek;
            int quantityWeek = 0;
            numberDayOfWeek = int.Parse(Console.ReadLine());
            if (numberDayOfWeek > 0 && numberDayOfWeek <= 7)
            {
                switch (numberDayOfWeek)
                {
                    case 1:
                        quantityWeek = (234 - numberDayOfWeek) / 7;
                        break;
                    case 2:
                        quantityWeek = (234 - numberDayOfWeek) / 7;
                        break;
                    case 3:
                        quantityWeek = (234 - numberDayOfWeek) / 7;
                        break;
                    case 4:
                        quantityWeek = (234 - numberDayOfWeek) / 7;
                        break;
                    case 5:
                        quantityWeek = (234 - numberDayOfWeek) / 7;
                        break;
                    case 6:
                        quantityWeek = (234 - numberDayOfWeek) / 7;
                        break;
                    case 7:
                        quantityWeek = (234 - numberDayOfWeek) / 7;
                        break;
                }
                Console.WriteLine($"За период 234 дня прошло {quantityWeek} недели.");
            }
            else
            {
                Console.WriteLine("Не корректный ввод данных!");
            }
            Console.WriteLine();

            // 5.Дано двузначное число. Найти:
            // число десятков в нем;
            // число единиц в нем;
            // сумму его цифр;
            // произведение его цифр
            int twoDigitNamber;
            Console.WriteLine("Введите двузначное число");
            twoDigitNamber = int.Parse(Console.ReadLine());
            Console.WriteLine("Число десяток = {0}", twoDigitNamber / 10);
            Console.WriteLine("Число единиц = {0}", twoDigitNamber % 10);
            Console.WriteLine("Сумма цифр = {0}", twoDigitNamber % 10 + twoDigitNamber / 10);
            Console.WriteLine("Произведение цифр = {0}", (twoDigitNamber / 10) * (twoDigitNamber % 10));
            Console.WriteLine();

            // 6.Дано четырехзначное число. Найти:
            // сумму его цифр;
            // произведение его цифр.
            int number = random.Next(1000,9999);
            int summaNumber = (number % 10) + (number / 10 % 10) + (number / 100 % 10) + (number / 1000);
            int multiplicationNumbers = (number % 10) * (number / 10 % 10) * (number / 100 % 10) * (number / 1000);            
            Console.WriteLine($"Сумма цифр числа {number} = {summaNumber}");
            Console.WriteLine($"Произведение цифр числа {number} = {multiplicationNumbers}");

            // 7.В трехзначном числе x зачеркнули его вторую цифру.
            // Когда к образованному при этом двузначному числу справа приписали вторую цифру числа x,
            // то получилось число 456.Найти число x.

            int value = 456;
            int firstValue = value % 10;
            int secondValue = value % 100;
            int thirdValue = value - secondValue;
            int xValue = thirdValue + (firstValue * 10) + (secondValue - firstValue) / 10;
            Console.WriteLine("Число х = " + xValue);

            // 8.Вычислить значение логического выражения при всех возможных значениях логических величин X и Y:
            // не X и не Y;
            // X или(не X и Y);
            // (не X и Y) или Y.

            bool X = true, Y = true;
            Console.WriteLine(!X && !Y);
            Console.WriteLine(X || (!X && Y));
            Console.WriteLine((!X && Y) || Y);
        }
    }
}
