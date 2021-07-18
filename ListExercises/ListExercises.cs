using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListExercises
{
    public class AddEvenNums
    {
        public void AddNums(List<int> numbers)
        {
            var evenNumbers = 0;

            foreach(int number in numbers)
            {
                if(number % 2 == 0)
                {
                    evenNumbers += number;
                }
            }
            Console.WriteLine(evenNumbers);
        }
      
    }

    public class PrintWordsByLength
    {
        public void PrintWords(List<string> words)
        {
            Console.WriteLine("Please enter a word length:\n");
            string input = Console.ReadLine();
            int wordLength = int.Parse(input);

            List<string> includedWords = new List<string> { };

            Console.WriteLine($"Words with a length of {wordLength} characters:\n");

            for (int i = 0; i < words.Count; i++)
            {
                if (words[i].Length == wordLength)
                {
                    Console.WriteLine(words[i]);
                } 
            }

        }
        
    }

    public class StringToList
    {
        public void MakeNewList(string sentence)
        {
            List<string> newList = sentence.Split('.').ToList();

            foreach (string line in newList)
            {
                Console.WriteLine(line);
            }
        }
    }
}
