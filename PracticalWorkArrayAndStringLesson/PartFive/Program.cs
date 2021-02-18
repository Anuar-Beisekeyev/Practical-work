using System;

namespace PartFive
{
    class Program
    {
        static void Main(string[] args)
        {
            //Дан двумерный массив размерностью 5×5,
            //заполненный случайными числами из диапазона от –100 до 100.
            //Определить сумму элементов массива, расположенных между минимальным и максимальным элементами.

            int[,] array = new int[5, 5];
            int summaArray = 0;
            int maxValue = array[0,0];
            int minValue = array[0,0];
            int min_i =0, min_j = 0, max_i = 0, max_j = 0; 
            Random random = new Random();
            for(int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(-100, 100);
                    if(maxValue < array[i,j])
                    {
                        maxValue = array[i,j];
                        max_i = i;
                        max_j = j;
                    }
                    if (minValue > array[i,j])
                    {
                        minValue = array[i,j];
                        min_i = i;
                        min_j = j;
                    }
                }
                
            }
            Console.WriteLine("Двухмерный массив: ");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i,j] + "  ");
                }
                Console.WriteLine();
            }
            bool flag = false;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if((i == max_i && j == max_j) || (i == min_i && j == min_j))
                    {
                        if (flag)
                        {
                            if (flag)
                            {
                                flag = false;
                                continue;
                            }
                            else
                            {
                                flag = true;
                                continue;
                            }

                        }
                        if (flag)
                        {
                            summaArray += array[i, j];
                        }
                    }
                }

            }
            Console.WriteLine("Максимальный элемент массива:" + maxValue);
            Console.WriteLine("Минимальный элемент массива:" + minValue);
            Console.WriteLine("Сумма меджу вторым минимальным и максимальным элементом = " +  summaArray);



        }
    }
}
