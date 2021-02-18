using System;

namespace PracticalWorkArrayAndStringLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            //Объявить одномерный(5 элементов ) массив с именем A и двумерный массив(3 строки, 4 столбца)
            //дробных чисел с именем B.Заполнить одномерный массив А числами, введенными с клавиатуры пользователем,
            //а двумерный массив В случайными числами с помощью циклов. Вывести на экран значения массивов:
            //массива А в одну строку, массива В — в виде матрицы.Найти в данных массивах общий максимальный элемент,
            //минимальный элемент, общую сумму всех элементов, общее произведение всех элементов,
            //сумму четных элементов массива А, сумму нечетных столбцов массива В.

            double[] A = new double[5];
            double[,] B = new double[3, 4];
            double generalSummaNum = 0;
            double generalMultNum = 1;            
            double summaEvenA = 0;
            double summaNoEvenB = 0;

            Random random = new Random();
            Console.WriteLine($"Введите значения для массива А: ");
            for(int i = 0; i < A.Length; i++)
            {
                Console.Write($"{i} элемент массива = ");
                if(!double.TryParse(Console.ReadLine(),out A[i]))
                {
                    Console.WriteLine("Не верный ввод данных!");
                }
                generalSummaNum = generalSummaNum + A[i];
                generalMultNum = generalMultNum * A[i];
                if(i % 2 == 0)
                {
                    summaEvenA += A[i];
                }
                
            }
            for(int i = 0; i < B.GetLength(0); i++)
            {
                for(int j = 0; j < B.GetLength(1); j++)
                {
                    B[i, j] = Math.Round(random.NextDouble(), 2) + random.Next(10);
                    generalSummaNum = generalSummaNum + B[i, j];
                    generalMultNum = generalMultNum * B[i, j];
                    if(j % 2 != 0)
                    {
                        summaNoEvenB += B[i, j];
                    }
                }
            }
            Console.WriteLine("Массив А: ");
            foreach(var item in A)
            {
                Console.Write(item + "  ");
            }
            Console.WriteLine();
            Console.WriteLine("Массив В:");
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    Console.Write(B[i, j] + "  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            double minA = A[0];
            double minB = B[0, 0];   
            for(int i = 0; i < A.Length; i++)
            {
                if(minA > A[i])
                {
                    minA = A[i];
                }
            }
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {                   
                    if (minB > B[i,j])
                    {
                        minB= B[i, j];
                    }
                }
            }
            Console.WriteLine("Минимальный элемент массива А = " + minA);
            Console.WriteLine("Минимальный элемент массива B = " + minB);
            double maxA = A[0];
            double maxB = B[0, 0];
            for (int i = 0; i < A.Length; i++)
            {
                if (maxA < A[i])
                {
                    maxA = A[i];
                }
            }
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    if (maxB < B[i, j])
                    {
                        maxB = B[i, j];
                    }
                }
            }
            Console.WriteLine("Максимальный элемент массива А = " + maxA);
            Console.WriteLine("Максимальный элемент массива B = " + maxB);
            if(minA == minB)
            {
                Console.WriteLine("Общий минимальный элемент массива А и В = " + minA);
            }
            else
            {
                Console.WriteLine("Общего минимального элемента в массивах нет");
            }
            if (maxA == maxB)
            {
                Console.WriteLine("Общий максимальный элемент массива А и В = " + maxA);
            }
            else
            {
                Console.WriteLine("Общего максимального элемента в массивах нет");
            }
            Console.WriteLine("Сумма всех элементов массивов А и В = " + generalSummaNum);
            Console.WriteLine("Произведение всех элементов массивов А и В = " + generalMultNum);
            Console.WriteLine("Сумма четных элементов массива А = " + summaEvenA);
            Console.WriteLine("Сумма нечетных элементов массивов В = " + summaNoEvenB);

        }
    }
}
