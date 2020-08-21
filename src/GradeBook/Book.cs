using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        public Book(string name)
        {
            grades = new List<int>();
            this.name = name;
        }


        public void AddGrade(int grade)
        {
            grades.Add(grade);
        }

        public Statistics GetStatistics()
        {

            var result = new Statistics();

            result.Average = 0;
            result.High = int.MinValue;
            result.Low = int.MaxValue;


            foreach (int grade in grades)
            {
                result.Low = Math.Min(grade, result.Low);
                result.High = Math.Max(grade, result.High);
                result.Average += grade;
            }

            result.Average /= grades.Count;

            return result;
        }

        List<int> grades;
        private string name;


    }
}