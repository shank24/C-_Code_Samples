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

            var book = new InMemoryBook("");
            book.AddGrade(90);
            book.AddGrade(80);
            book.AddGrade(70);

            // act
            var result = book.GetStatistics();

            //assert
            Assert.Equal(80,result.Average);
            Assert.Equal(90,result.High);
            Assert.Equal(70,result.Low);
            Assert.Equal('B',result.Letter);


        }
    }
}
