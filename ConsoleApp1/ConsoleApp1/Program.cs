using System;
using System.Collections.Generic;
using System.IO;

namespace PracticalWorkFileIOLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            //Написать программу, читающую побайтно заданный файл
            //и подсчитывающую число появлений каждого из 256 возможных знаков.

            Dictionary<char, int> score = new Dictionary<char, int>();

            using(FileStream stream = new FileStream(@"G:\Академия step\С#\test.txt", FileMode.OpenOrCreate))
            {
                byte[] bytes = new byte[stream.Length];
                stream.Read(bytes, 0, bytes.Length);

                string text = System.Text.Encoding.UTF8.GetString(bytes);
                foreach(var symbol in text)
                {
                    if (score.ContainsKey(symbol))
                    {
                        score[symbol]++;
                    }
                    else
                    {
                        score[symbol] = 0;
                    }
                }
                Console.WriteLine(text);
            }
            foreach(KeyValuePair<char,int> item in score)
            {
                Console.WriteLine($"{item.Key} ={item.Value +1}");
            }

            //С помощью класса StreamWriter записать в текстовый файл свое имя,
            //фамилию и возраст. Каждая запись должна начинаться с новой строки.

            string path = @"G:\Академия step\С#\Full name.txt";

            using(StreamWriter stream = new StreamWriter(path))
            {
                stream.WriteLine("Бейсекеев");
                stream.WriteLine("Ануар");
                stream.WriteLine("28");
            }


        }
    }
}
