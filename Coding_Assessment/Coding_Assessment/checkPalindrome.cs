using System;
namespace Coding_Assessment
{
    public class checkPalindrome
    {
        public bool CheckPalindrome(string word)
        {
            //initialize the variable that will store the reverse value of the word or sentence
            string revWord = "";

            //convert to lower case the word or sentence
            word = word.ToLower();

            //loop through the word to reverse it and make sure we are not counting a single character
            if (word.Length > 1) { 
                int v = word.Length - 1;
                for (int j = v; j >= 0; j--)
                {
                    revWord += word[j];
                }
            
            //return true is the word is equal to his reverse or false if not
            if (word == revWord) { return true; }
            else { return false; }
            }
            return false;
        }
    }
}
