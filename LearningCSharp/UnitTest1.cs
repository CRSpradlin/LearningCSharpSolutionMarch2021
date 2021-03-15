using System;
using Xunit;

namespace LearningCSharp
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // Given (Arrange)clean and pure world.
            int a = 10, b = 20, answer;

            // When (Act) stimulate the code way
            answer = a + b;
            // Then (Assert) observe what happened.
            Assert.Equal(30, answer);
        }
        [Theory]
        [InlineData(2,2,4)]
        [InlineData(10,5, 15)]
        [InlineData(12,2,14)]
        public void CanAddTwoNumbers(int a, int b, int expected)
        {
            int sum = a + b;
            Assert.Equal(expected, sum);
        }
    }
}
