using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;


namespace Book
{
    class Program
    {
        static void Main(string[] args)
        {

            // instantiate an instance of the context
            BookContext context = new BookContext();

            // makes sure that the table exists, 
            //and creates it if it does not already exist
            context.Database.EnsureCreated();

            // ask the user for a book to add
            string titlePrompt = "Add book '[Title]': ";
            Console.WriteLine(titlePrompt);

            String title = Console.ReadLine();

            string authorPrompt = "Add book '[Author]': ";
            Console.WriteLine(authorPrompt);

            String author = Console.ReadLine();

            // create a new book object, notce that we do not 
            // select an id, we let the framework handle that
            Book newBook = new Book(title, author);

            // add the newly created student instance to the context
            // notice how similar this is to adding a item to a list,
            context.books.Add(newBook);

            // ask the context to save any changes to the database 
            context.SaveChanges();
            Console.WriteLine("Added the Title and Author.");

            Console.WriteLine("The Current List of books are: ");
            // use a for each loop to loop through the books in the context
            // notice how similar this is to looping through a list
            foreach (Book b in context.books)
            {
                Console.WriteLine("{0} - {1} by {2}",
                     b.Id, b.Title, b.Author);
            }


        }
    }
}
