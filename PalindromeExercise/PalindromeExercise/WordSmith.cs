using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string word)
        {
            if (word == null || word == "")
            {
                return false;
            }

            //reverse
            //var reverse = "";

            //for (int i = word.Length-1; i >= 0 ; i--)
            //{
            //    reverse += word[i];
            //}
            ////compare
            //if (reverse.ToLower() == word.ToLower())
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
            ////return

            //var reverse = word.Reverse();

            //if (reverse == word)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}

            if (String.IsNullOrEmpty(word)) //eliminates null or empty immediately
            {
                return false;
            }

            var specialCharacters = " ?!,.@#%&";
            for (int i = 0; i < specialCharacters.Length; i++)  //converts special characters to nothing to take its place
            {
                word = word.Replace(specialCharacters[i].ToString(), ""); 
            }
            if (word == "")  //if converted special character string is nothing after converstion, false
            {
                return false;
            }

            else
            {
                char[] wordArray = word.ToCharArray(); //convert string to character array, then reverse array
                Array.Reverse(wordArray);
                string arrayReversedToString = new string(wordArray); //then reversed array to string
                if (word.ToLower() == arrayReversedToString.ToLower()) //then verify new reversed string equals original string
                {
                    return true;
                }
            }

            return false;

        }

    }
}
