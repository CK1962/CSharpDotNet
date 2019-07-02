using Microsoft.EntityFrameworkCore;
using System;
using System.IO;

namespace CP_ToDoApp1
{
    public class ItemContext : DbContext
    {
        // This property corresponds to the table in our database
        public DbSet<ToDoItem> ToDos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // get the directory the code is being executed from
            DirectoryInfo ExeDirectory = new DirectoryInfo(AppContext.BaseDirectory);

            // get the base directory for the project
            DirectoryInfo ProjectBase = ExeDirectory.Parent.Parent.Parent;

            // add 'todo.db' to the project directory
            String DbFile = Path.Combine(ProjectBase.FullName, "todo.db");

            // to check what the path of the file is, uncomment the file below
            //Console.WriteLine("using database file :" + DbFile);

            optionsBuilder.UseSqlite("Data Source=" + DbFile);
        }
    }
}