using System;
using System.Collections.Generic;
using System.Text;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string word)
        {

            if(word == null || word.Length == 0)
            {
                return false;
            }

            string wordLowered = word.ToLower();
            string backwards = "";

            for(int i = word.Length -1; i >=0; i--)
            {
                backwards += wordLowered[i];
            }

            return wordLowered == backwards;

            //if(word == backwards)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
        }
    }
}
