using System;
using System.Linq;

namespace PartThree
{
    class Program
    {
        static void Main(string[] args)
        {
            //Пользователь вводит строку.
            //Проверить, является ли эта строка палиндромом.
            //Палиндромом называется строка,
            //которая одинаково читается слева направо и справа налево.

            Console.WriteLine("Введите строку: ");
            string line = Console.ReadLine();
            char[] temp = new char[line.Length];
            int j = 0;
            int count = 0;
            for(int i = 0; i < line.Length; i++)
            {
                if(line[i] == ' ')
                {
                    count++;
                    continue;
                }
                temp[j] = line[i];
                j++;
            }
            Array.Resize(ref temp, line.Length - count);
            string output = new string(temp);
            Console.WriteLine(line);
            line = output;
            output = new string(output.ToCharArray().Reverse().ToArray());
            if(String.Compare(line,output,true) == 0)
            {
                Console.WriteLine("Строка является палиндромом");
            }
            else
            {
                Console.WriteLine("Строка не является палиндромом");
            }

        }
    }
}
