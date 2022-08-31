
using PalindromeExercise;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace PalindromeExerciseTests
{
    public class WordSmithTest
    {
        [Theory]
        [InlineData("Racecar", true)]
        [InlineData("hannah", true)]
        [InlineData("kayak", true)]
        [InlineData("John", false)]
        [InlineData("Jose", false)]
        [InlineData("null", false)]

        public void IsAPalindrome_Test(string word, bool expected)
        {
            var ws = new WordSmith();

            var actual = ws.IsAPalindrome(word);

            Assert.Equal(expected, actual);
        }

    }
}
