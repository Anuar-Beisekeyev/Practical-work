using System;
using System.Collections.Generic;
using System.Text;

namespace PracticalWorkInterfaceLesson
{
    public class Student : IStudent
    {
        public string Name { get ; set ; }
        public string FullName { get ; set ; }
        public int[] Grades { get ; set ; }

        public double GetAvgGrade()
        {
            double avgGrade = 0;
            for (int i = 0; i < Grades.Length; i++)
            {
                avgGrade += Grades[i];
            }
            avgGrade = avgGrade / Grades.Length;
            return avgGrade;
        }

        public string GetFullName()
        {
            return FullName;
        }

        public string GetName()
        {
            return Name;
        }
    }
}
