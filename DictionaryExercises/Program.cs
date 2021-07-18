using System;
using System.Collections.Generic;

namespace DictionaryExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> students = new Dictionary<int, string>();

            ClassRoster allStudents = new ClassRoster();

            allStudents.GetNamesAndIDs(students);
            allStudents.PrintClassRoster(students);

            
        }
    }
}
