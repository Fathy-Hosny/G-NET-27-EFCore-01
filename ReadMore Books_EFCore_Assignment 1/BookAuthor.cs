using System;
using System.Collections.Generic;
using System.Text;

namespace ReadMore_Books_EFCore_Assignment_1
{
    public class BookAuthor
    {
        public int BookId { get; set; }
        public int AuthorId { get; set; }

        public Book Book { get; set; } = null!;
        public Author Author { get; set; } = null!;
    }
}
