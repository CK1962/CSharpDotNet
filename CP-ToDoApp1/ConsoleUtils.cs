using System;

namespace CP_ToDoApp1
{
    public static class ConsoleUtils
    {
        public static void DisplayMenu()
        {
            Console.WriteLine();
            DisplayHeader("Menu");
            Console.WriteLine(@"
What would you like to do: 
1: List pending items
2: List done items
3: List all items    
4: Mark done                
5: Add item
6: Delete item
7: Exit
            ");
        }

        public static int GetCommand()
        {
            string input = Console.ReadLine();

            bool succeeded = int.TryParse(input, out int command);
            if (!succeeded)
            {
                Console.WriteLine("Invalid input; try again.");
                return 0;
            }

            if (command > 7)
            {
                Console.WriteLine("Invalid input; try again.");
                return 0;
            }

            return command;
        }

        public static void DisplayHeader(string headerText)
        {
            Console.WriteLine("***********************************************");
            Console.WriteLine(headerText.ToUpper());
            Console.WriteLine("***********************************************");
        }

        public static void DisplayItem(ToDoItem item)
        {
            string statusDescription = item.IsDone ? "DONE" : "PENDING";
            Console.WriteLine($"Id #{item.Id}: {item.Description} -- {statusDescription}");
        }

        public static void WriteMessage(string message)
        {
            Console.WriteLine(message);
        }

        private static int ReadInt()
        {
            string input = Console.ReadLine();

            bool succeeded = int.TryParse(input, out int output);
            if (!succeeded)
            {
                Console.WriteLine("Invalid input; try again.");
                return 0;
            }

            return output;
        }

        public static int RequestId(string message)
        {
            ConsoleUtils.WriteMessage(message);
            int id = ConsoleUtils.ReadInt();
            return id;
        }
    }
}