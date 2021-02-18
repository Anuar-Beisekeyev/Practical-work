using System;

namespace PracticalWorkInterfaceLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student
            {
                Name = "Tom",
                FullName = "Smit",
                Grades = new[] { 10, 9, 8, 9, 10, 11 }
            };

            Console.WriteLine("Name: " + student.GetName());
            Console.WriteLine("Full name: " + student.GetFullName());
            Console.WriteLine("Average rating: " + student.GetAvgGrade());
        }
    }
}
