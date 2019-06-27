using System;


namespace Book
{
    class Program
    {
        static void Main(string[] args)
        {
            BookContext context = new BookContext();
            context.Database.EnsureCreated();

            // ask the user for a title to add
            Console.WriteLine("Enter Title and Author of a book: ");
            String title = Console.ReadLine();
            string[] nameParts = title.Split();

            Book newBook = new book(nameParts[0], nameParts[1]);
            context.book.Add(newBook);

        }
    }
}
