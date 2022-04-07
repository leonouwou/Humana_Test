using System;
using System.Collections.Generic;
using System.Linq;

namespace Coding_Assessment
{
    public class listOfLetter
    {
        public List<string> ListOfLetter(string letter, Dictionary<string, int> myDictionary)
        {
            //initializing a list to store words that contain the letter
            List<string> words=new List<string>{ };

            //We are looping through the dictionnary to check if the key contains the letter
            foreach (var item in myDictionary)
            {
                if (item.Key.Contains(letter))
                {
                    words.Add(item.Key);
                }
            }

            //return the list
            return words;
        }
    }
}
