using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("red rum, sir, is murder", true)]
        [InlineData("final", false)]
        [InlineData("fantasy", false)]
        [InlineData("sagas", true)]
        [InlineData("Never odd or even.", true)]
        [InlineData("", false)]
        [InlineData(null, false)]

        public void IsAPalindromeTest(string word, bool expected)
        {
            //Arrange
            var test = new WordSmith();

            //Act
            var actual = test.IsAPalindrome(word);

            //Assert
            Assert.Equal(expected, actual);

        }
    }
}
