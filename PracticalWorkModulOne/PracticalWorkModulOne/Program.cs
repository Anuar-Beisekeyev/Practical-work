using System;

namespace PracticalWorkModulOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Бейсекеев Ануар");
            Console.WriteLine("Введите число 1:");
            double firstValue = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите число 2:");
            double secondValue = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите число 3:");
            double thirdValue = double.Parse(Console.ReadLine());
            double resultSum = firstValue + secondValue + thirdValue;
            Console.WriteLine("Сумма введенных чисел = " + resultSum);
        }
    }
}
