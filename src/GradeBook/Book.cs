using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        public Book(string name)
        {
            grades = new List<int>();
            Name = name;
        }


        public void AddGrade(int grade)
        {
            if (grade <= 100 && grade >= 0)
            {
                grades.Add(grade);
            }
            else{
                System.Console.WriteLine("Invalid Value");
            }
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
        public string Name;

    }
}