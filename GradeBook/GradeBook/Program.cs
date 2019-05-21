using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> gradebook = new Dictionary<string, string>();

            bool shouldContinue = true;
            do
            {
                Console.WriteLine("Please enter the student name (or 'quit'): ");
                string studentName = Console.ReadLine();
                if (studentName == "quit")
                {
                    shouldContinue = false;
                }
                else
                {
                    Console.WriteLine("Please input the Grades in one string separated by a space...example - 85 77 92:");

                    string gradesInput = Console.ReadLine();

                    gradebook.Add(studentName, gradesInput);
                }
            }
            while (shouldContinue);


            // process grades
            foreach(var student in gradebook)
            {
                ComputedGrades(student.Key, student.Value);
            }
            Console.ReadLine();
        }

        private static void ComputedGrades(string studentName, string gradesInput)
        {
            string[] gradeArray = gradesInput.Split(' ');
            int[] grades = new int[gradeArray.Length];
            for (int i = 0; i < gradeArray.Length; i++)
            {
                grades[i] = Convert.ToInt32(gradeArray[i]);
            }

            int highestGrade = grades.Max();
            int lowestGrade = grades.Min();
            double averageGrade = grades.Average();

            Console.WriteLine($"The average for {studentName} is {averageGrade} and the Highest grade is {highestGrade} and the Lowest grade is {lowestGrade}. please select any character to exit the program!");
        }
    }
}