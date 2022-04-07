using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Coding_Assessment
{
    public class uniqueWords
    {
        public Dictionary<string, int> UniqueWords(string paragraph)
        {
            var list = new Dictionary<string, int>();

            string word = "";

            paragraph = Regex.Replace(paragraph, @"[^\w\s]", "");


            paragraph += " ";
            for (int i = 0; i < paragraph.Length; i++)
            {
                // extracting each word of the paragraph
                char ch = paragraph[i];

                //Checking if the next chararcter is not a colon or space
                if (ch != '.' && ch!=' ' )
                {
                    word += ch;

                }
                else
                {
                    //check if word in the dictionnary and the word not a column
                    if (word != ".")
                    {
                        //increment the value of the key
                        if (list.ContainsKey(word))
                        {
                            list[word]++;
                        }

                        //add the word to the dictionnary
                        else
                        {
                            list.Add(word, 1);
                        }
                    }

                    //renitialize the word
                    word = "";

                }
            }

            //return the dictionnary
            return list;
        }
    }
}
