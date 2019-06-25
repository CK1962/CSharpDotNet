using System;

namespace DbContext
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

         // add the following import to the top for your
    using Microsoft.EntityFrameworkCore;


    class StudentsContext : DbContext
    {

        // This property corresponds to the table in our database
        public DbSet<Student> students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // this tells the framework which file to use as the database
            optionsBuilder.UseSqlite("Data Source=students.db");
        }
    }
}
}
