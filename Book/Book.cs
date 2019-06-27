using System;
using System.Collections.Generic;
using System.Text;

namespace Book
{
    class Book
    {
        // notice the private set on the id
        public int Id { get; private set; }
        public String Title { get; set; }
        public String Author { get; set; }
        public Book(String title, String author)
        {
            this.Title = title;
            this.Author = author;
        }
    }
}