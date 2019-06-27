using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.IO;

namespace Student
{
    class BookContext : DbContext
    {

        // This property corresponds to the table in our database
        public DbSet<Book> books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // get the directory the code is being executed from
            DirectoryInfo ExeDirectory = new DirectoryInfo(AppContext.BaseDirectory);

            // get the base directory for the project
            DirectoryInfo ProjectBase = ExeDirectory.Parent.Parent.Parent;

            // add 'students.db' to the project directory
            String DbFile = Path.Combine(ProjectBase.Title, "book.db");

            // to check what the path of the file is, uncomment the file below
            Console.WriteLine("using database file :" + DbFile);

            optionsBuilder.UseSqlite("Data Source=" + DbFile);
        }
    }
}
