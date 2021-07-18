using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayExercises
{
    class OddNums
    {
        public void PrintOddNumbers(int[] numbers)
        {
            for (int i = 0; i < 6; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    Console.WriteLine(numbers[i]);
                }
            }
        }
    }
}
