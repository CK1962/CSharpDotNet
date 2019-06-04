using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoItem
{
    class Program
    {
        static void Main(string[] args)
        {
            string question = "Would you like to add your To Do item?";
            Console.WriteLine(question);
            string answer = Console.ReadLine().ToLower();
                list<ToDoItem> toDoList = new list<ToDoItem>();
            while (answer != "no")
                foreach (ToDoItem item in toDoList)
                    Console.ReadKey();
            Console.WriteLine("Please tell me the date this item is due");
            Console.ReadLine();
            Console.WriteLine("Please give this item a priority(high, normal, low");
            Console.ReadLine();
        }
        class ToDoItem
        {

            public String Description { get; set; }
            public String DueDate { get; set; }
            public String Priority { get; set; }

            public ToDoItem(string description, string due_date, string priority)
            {
                Description = description;
                DueDate = due_date;
                Priority = priority;
            }

        }
    }
}