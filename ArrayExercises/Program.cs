﻿using System;

namespace ArrayExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 1, 2, 3, 5, 8 };

            foreach(int number in numbers)
            {
                Console.WriteLine(number);
            }

            OddNums oddNumbers = new OddNums();

            oddNumbers.PrintOddNumbers(numbers);
        }
    }
}
