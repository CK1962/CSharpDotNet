using System;

namespace Student
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentContext context = new StudentContext();
            context.Database.EnsureCreated();

            // ask the user for a student to add
            Console.WriteLine("Enter Student full name");
            String fullName = Console.ReadLine();
            string[] nameParts = fullName.Split();

            Student newStudent = new Student(nameParts[0], nameParts[1]);
            context.students.Add(newStudent);
           
        }
    }
}
