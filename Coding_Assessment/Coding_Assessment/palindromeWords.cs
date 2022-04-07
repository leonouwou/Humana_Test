using System;
using System.Text.RegularExpressions;

namespace Coding_Assessment
{
    public class palindromeWords
    {
        public string PalindromeWords(string paragraph)
        {

            // We store each word
            string word = "";

            //We store the variable that will count the number of palindrome
            int count = 0;

            //We removing all ponctuation from the paragraph
            paragraph=Regex.Replace(paragraph, @"[^\w\s.]", "");

            //We add a space to be able to loop through the whole paragraph
            paragraph += " ";

            //We loop through the paragraph to get each word
            for (int i = 0; i < paragraph.Length; i++)
            {
                // extracting each word of the paragraph
                char ch = paragraph[i];

                //Checking if the next chararcter is not a space
                if (ch != ' ' && ch!='.')
                {
                    word += ch;

                }

                else
                {
                    //we called our method class checkPalindrome to check if the word is a palindrome
                    checkPalindrome check = new checkPalindrome();

                    if (check.CheckPalindrome(word.Trim())==true)
                    {
                        count++;
                    }
                    word = "";
                    
                }
            }
            //End of the loop

            //message displayed with the number of palindrome found in the paragraph
            if (count == 1 || count==0) { return "We have " + count + " palindrome word in this paragraph"; }
            else { return "We have " + count + " palindrome words in this paragraph"; }
            

        }
    }
}
