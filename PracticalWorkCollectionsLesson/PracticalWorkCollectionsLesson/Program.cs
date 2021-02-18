using System;
using System.Collections;

namespace PracticalWorkCollectionsLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            int avgSumma = 0;
            Random random = new Random();
            Console.WriteLine("Список:");
            for (int i = 0; i < 40; i++)
            {
                list.Add(random.Next(-50, 100));
                Console.Write(list[i] + "  ");
            }
            Console.WriteLine();
            for(int i = 0; i < list.Count; i++)
            {
                if(i % 2 == 1)
                {
                    list.RemoveAt(i);
                }
            }
            Console.WriteLine("Список в которых были удалены нечетные элементы");
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + "  ");
            }

            for (int i = 0; i < list.Count; i++)
            {
                avgSumma += (int)list[i];
            }
            avgSumma /= list.Count;
            Console.WriteLine();
            Console.WriteLine("Среднее арифметическое значение списка = " + avgSumma );
            Console.WriteLine("Список элементов больше средней сумы всех элементов");
            foreach(int item in list)
            {
                if(item > avgSumma)
                {
                    Console.Write(item + "  ");
                }
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
