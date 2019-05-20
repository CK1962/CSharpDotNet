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
            /*Gradebook book = new Grades();
            book.AddGrade(91);
            book.AddGrade(89);
            book.AddGrade(83.5f);
            book.AddGrade(78);
            book.AddGrade(98);
            book.AddGrade(93);
            book.AddGrade(79);
            book.AddGrade(64);
            book.AddGrade(32);
            book.AddGrade(45);
            book.AddGrade(67);
            book.AddGrade(90);
            book.AddGrade(58);
            book.AddGrade(72);
            book.AddGrade(100);
            book.AddGrade(85);*/

            Console.WriteLine("Please input the Grades:");

            Gradebook inputValues = new Grades();
            inputValues.AddGrade(85);
            inputValues.AddGrade(62);


            GradeStatistics stats = inputValues.ComputeStatistics();
            //Console.WriteLine(stats.HighestGrade);
            //Console.WriteLine(stats.AverageGrade);
            //Console.WriteLine(stats.LowestGrade);
            Console.WriteLine("The average for this person is {0} and the Highest grade he made is {1} and the Lowest is {2}. If you May please select any character to exit the program!", stats.AverageGrade, stats.HighestGrade, stats.LowestGrade);

        }
    }
}