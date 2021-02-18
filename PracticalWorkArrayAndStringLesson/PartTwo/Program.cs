using System;
using System.Linq;

namespace PartTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Даны 2 массива размерности M и N соответственно.
            //Необходимо переписать в третий массив общие
            //элементы первых двух массивов без повторений. 

            Console.WriteLine("Введите размерность массива М:");
            if(!int.TryParse(Console.ReadLine(), out int sixeArrayM))
            {
                Console.WriteLine("Не верный ввод!");
            }
            Console.WriteLine("Введите размерность массива N:");
            if (!int.TryParse(Console.ReadLine(), out int sixeArrayN))
            {
                Console.WriteLine("Не верный ввод!");
            }
            Random random = new Random();
            int count = 0;
            int[] M = new int[sixeArrayM];
            int[] N = new int[sixeArrayN];

            for (int i = 0; i < M.Length; i++)
            {
                M[i] = random.Next(0, 10);
            }

            for (int i = 0; i < N.Length; i++)
            {
                N[i] = random.Next(0, 10);
                for (int j = 0; j < M.Length; j++)
                {
                    if(N[i] == M[j])
                    {
                        count++; 
                    }
                }
            }
            Console.WriteLine("Массив M =");
            foreach(var item in M)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Массив N =");
            foreach(var item in N)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            if(count != 0)
            {
                int[] MN = new int[count];
                int k = 0;
                for(int i = 0; i < N.Length; i++)
                {
                    for(int j = 0; j < M.Length; j++)
                    {
                        if(N[i] == M[j] && (!MN.Contains(N[i])))
                        {
                            MN[k] = N[i];
                            k++;
                        }
                    }
                }
                Array.Resize(ref MN, k);
                Console.WriteLine("Массив MN = ");
                foreach(var item in MN)
                {
                    Console.Write(item + " ");
                }
            }
            else
            {
                Console.WriteLine("Общих элементов нет!");
            }


        }
    }
}
