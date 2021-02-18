using System;

namespace PartFour
{
    class Program
    {
        static void Main(string[] args)
        {
            //Подсчитать количество слов во введенном предложении.
            Console.WriteLine("Введите строку: ");
            string str = Console.ReadLine();
            int count = 0;
            for(int i = 0; i < str.Length; i++)
            {
                if(str[i] == ' ')
                {
                    count++;
                }
            }
            Console.WriteLine($"Количество слов в строке: {str} = {count}");

        }
    }
}
