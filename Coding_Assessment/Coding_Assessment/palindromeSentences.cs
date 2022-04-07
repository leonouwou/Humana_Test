using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Coding_Assessment
{
    public class palindromeSentences
    {
        public string PalindromeSentences(string paragraph)
        {
            // We store each word
            string sentence = "";


            //We store the variable that will count the number of palindrome
            int count = 0;

            //We removing all ponctuation from the paragraph
            paragraph = Regex.Replace(paragraph, @"[^\w\s.]", "");

            //We add a space to be able to loop through the whole paragraph
            paragraph += ".";


            //We loop through the paragraph to get each character
            for (int i = 0; i < paragraph.Length; i++)
            {
                // extracting each word of the paragraph
                char ch = paragraph[i];

                //Checking if the next chararcter is not a colon
                if (ch != '.')
                {
                    sentence += ch;
                    
                }

                else
                {

                    //we called our method class checkPalindrome to check if the sentence is a palindrome and removing white spaces in the process
                    checkPalindrome check = new checkPalindrome();
                    if (check.CheckPalindrome(sentence.Replace(" ", "")) == true)
                    {
                        count++;

                    }

                    //renitializing the sentence
                    sentence = "";

                }
            }
            //End of the loop

            //message displayed with the number of palindrome found in the paragraph
            if (count == 1 || count == 0) { return "We have " + count + " palindrome sentence in this paragraph "; }
            else { return "We have " + count + " palindrome sentences in this paragraph "; }


        }
    }
}
