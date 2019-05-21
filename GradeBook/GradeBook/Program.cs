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
            Console.WriteLine("Please enter the student name: ");
            string studentName = Console.ReadLine();
            Console.WriteLine("Please input the Grades in one string separated by a space...example - 85 77 92:");
            string gradesinput = Console.ReadLine();
            string[] gradeArray = gradesinput.Split(' ');
            int[] grades = new int[gradeArray.Length];
            for(int i = 0; i< gradeArray.Length; i++)
            {
                grades[i] = Convert.ToInt32(gradeArray [i]);
            }

            int highestGrade = grades.Max();
            int lowestGrade = grades.Min();
            double averageGrade = grades.Average();

            //Console.WriteLine(stats.HighestGrade);
            //Console.WriteLine(stats.AverageGrade);
            //Console.WriteLine(stats.LowestGrade);
            //Console.WriteLine("The average for this person is {0} and the Highest grade he made is {1} and the Lowest is {2}. please select any character to exit the program!", stats.AverageGrade, stats.HighestGrade, stats.LowestGrade);
            Console.WriteLine($"The average for this person is {averageGrade} and the Highest grade he made is {highestGrade} and the Lowest is {lowestGrade}. please select any character to exit the program!");
            Console.ReadLine();
        }
    }
}