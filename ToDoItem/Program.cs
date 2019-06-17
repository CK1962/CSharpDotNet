using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoItem
{
    class Program
    {
        static List<ToDoItem> ToDoList;

        static void Main(string[] args)
        {
            ToDoList = new List<ToDoItem>();
            bool keepGoing = true;

            while (keepGoing == true)
            {
                string question = "Would you like to keep going or exit?";
                Console.WriteLine(question);
                string answer = Console.ReadLine().ToLower();
                if (answer == "exit")
                {
                    keepGoing = false;
                    break;
                }
                Console.WriteLine("Please give me the description: ");
                string descriptionInput = Console.ReadLine();

                Console.WriteLine("Please tell me the date this item is due: ");
                string dateInput = Console.ReadLine();

                Console.WriteLine("Please give this item a priority(high, normal, low: ");
                string priorityInput = Console.ReadLine();

                ToDoItem obj1 = new ToDoItem(descriptionInput, dateInput, priorityInput);
                ToDoList.Add(obj1);
            }

            foreach (ToDoItem item in ToDoList)
            {
                Console.WriteLine($"description: {item.Description}; due date: {item.DueDate}; priority: {item.Priority}");
            }
            Console.ReadLine();
        }


        class ToDoItem
        {

            public String Description { get; set; }
            public String DueDate { get; set; }
            public String Priority { get; set; }

            public ToDoItem(string description, String due_date, string priority)
            {
                Description = description;
                DueDate = due_date;
                Priority = priority;
            }

        }
    }
}