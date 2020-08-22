using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void CalculateStatistics()
        {
            // arrange

            var book = new Book("");
            book.AddGrade(10);
            book.AddGrade(20);
            book.AddGrade(30);

            // act
            var result = book.GetStatistics();

            //assert
            Assert.Equal(20,result.Average);
            Assert.Equal(30,result.High);
            Assert.Equal(10,result.Low);            
        }
    }
}
