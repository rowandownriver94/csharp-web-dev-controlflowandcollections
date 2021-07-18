using System;
using System.Collections.Generic;

namespace ListExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //Adding all even numbers in a List: 

            var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            AddEvenNums evens = new AddEvenNums();

            evens.AddNums(numbers);


            //Finding words by char length:
            
            var words = new List<string> { "Babushka", "Moth", "So", "Granfalloon", "Snollygoster", "Babka", "Reticulated", "Egragore", "Doppelgangers", "Awen", "Life", "Soft", "Benign", "Ephemeral", "Nox", "Blunderbuss", "Parallax", "Serenity", "Supercalifragilisticexpialidocious", "Frog", "Bop", "Pi", "Is", "Dog", "Cat", "Crass", "Indica", "Mimicry", "Lachrymatory", "Apple", "Hawk", "Balloon", "Ex", "Miss", "Bat", "Quasar", "Basil", "Boba", "Kafkaesque", "Laser", "Fluffy", "Euclid", "Garlic", "Four", "Plinth", "Shine", "Opal", "Ramp", "Barmbrack" };
            //var suess = "I would not, could not, in a box. I would not, could not with a fox. I will not eat them in a house. I will not eat them with a mouse.";



            PrintWordsByLength wordLengths = new PrintWordsByLength();
            //StringToList newList = new StringToList();


            wordLengths.PrintWords(words);
            //newList.MakeNewList(suess);

        }
    }
}
