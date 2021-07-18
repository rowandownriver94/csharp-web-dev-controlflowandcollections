using System;
using System.Collections.Generic;
using System.Text;

namespace StringExercises
{
    class SplitSentence
    {
        public void SplitBySpace(string sentence)
        {
            string[] newArray = sentence.Split(' ');


            Console.WriteLine(string.Join(",", newArray));
        }

        public void SplitByPeriod(string sentence)
        {
            string[] newArray = sentence.Split('.');

            foreach (string word in newArray)
            {
                Console.WriteLine(word);
            }
        }
    }
}
