using System;

namespace PracticalWorkExceptionLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new TestClass();

            try
            {
                string word = "C#";
                test.IsString(word);
            }
            catch(Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            try
            {
                int number= 5;
                test.IsString(number);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            Console.ReadLine();

        }
    }
}
