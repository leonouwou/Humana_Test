using System;
using System.Collections.Generic;

namespace Coding_Assessment
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            string text = "this is ofo ewe madam  this this. was it a cat I saw. I did, did I?";

            //We are calling the palindromeWords method to determine the number of palindrome word in the paragraph
            palindromeWords p = new palindromeWords();
            Console.WriteLine(p.PalindromeWords(text));

            //We are calling the palindromeWords method to determine the number of palindrome word in the paragraph
            palindromeSentences s = new palindromeSentences();
            Console.WriteLine(s.PalindromeSentences(text));

            //We are calling the method that generated the list of word with the count of the word instance
            uniqueWords u = new uniqueWords();
            var r = u.UniqueWords(text);

            Console.WriteLine("The list of word with the count of the word instance");
            foreach (var i in r) {
                Console.WriteLine(i);
            };

            Console.WriteLine("Enter a letter: ");
            string l = Console.ReadLine();

            //We are calling the listLetter method to return the list of word that contains the letter we are passing in parameter
            listOfLetter listLetter = new listOfLetter();
            var li=listLetter.ListOfLetter(l, r);

            //Looping through the list to display it

            if (li.Count == 0)
            {
                Console.WriteLine("We do not have the letter " + l + " in the sentence");
            }
            else
            {
                Console.WriteLine("The list of word that contains the letter " + l + " is:");
                foreach (var wordi in li)
                {
                    Console.WriteLine(wordi);

                }
            }
        }
    }
}
