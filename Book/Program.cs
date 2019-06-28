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
           string prompt = "Would you like to add books to the inventory (y/n)?";
            String book = Console.ReadLine();

            // split the input into parts, and make sure 
            // we have 2 parts only
            String[] parts = book.Split();
            if (parts.Length == 2)
            {
                // create a new book object, notce that we do not 
                // select an id, we let the framework handle that
                Book newBook = new Book(parts[0], parts[1], parts[3]);

                // add the newly created student instance to the context
                // notice how similar this is to adding a item to a list,
                context.book.Add(newBook);

                // ask the context to save any changes to the database 
                context.SaveChanges();
                Console.WriteLine("Added the Title and Author.");
            }
            else
            {
                Console.WriteLine("Invalid Title or Author, did not add book");
            }

            Console.WriteLine("The Current List of books are: ");
            // use a for each loop to loop through the books in the context
            // notice how similar this is to looping through a list
            foreach (Book b in context.book)
            {
                Console.WriteLine("{0} - {1} {2}",
                     b.Id, b.Title, b.Author);
            }


        }
    }
}
