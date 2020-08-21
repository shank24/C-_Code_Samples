
using System;
using System.Collections.Generic;

namespace GradeBook
{

    class Program
    {
        static void Main(string[] args)
        {

            var book = new Book("Java");

            book.AddGrade(12);
            book.AddGrade(22);
            book.AddGrade(32);
            var stats = book.GetStatistics();
            
            System.Console.WriteLine($"The lowest grade is {stats.Low}");
            System.Console.WriteLine($"The highest grade is {stats.High}");
            System.Console.WriteLine($"The average grade is {stats.Average:N1}");

            

            
        }
    }

}
