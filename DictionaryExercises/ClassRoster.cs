using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryExercises
{
    class ClassRoster
    {
        public void GetNamesAndIDs(Dictionary<int, string> students)
        {
            string newStudent;

            Console.WriteLine("Enter your students (or ENTER to finish)");

            //get student names and IDs

            do
            {
                Console.WriteLine("Student: ");
                string input = Console.ReadLine();
                newStudent = input;

                if (!Equals(newStudent, ""))
                {
                    Console.WriteLine("ID: ");
                    input = Console.ReadLine();
                    int newID = int.Parse(input);
                    students.Add(newID, newStudent);

                    //read the newline before looping back
                    Console.ReadLine();
                }
            } while (!Equals(newStudent, ""));
        }



        public void PrintClassRoster(Dictionary<int, string> students)
        {
            Console.WriteLine("\nClass roster: ");

            foreach (KeyValuePair<int, string> student in students)
            {
                Console.WriteLine($"{student.Key} ({student.Value})");
            }
        }
    }
}
