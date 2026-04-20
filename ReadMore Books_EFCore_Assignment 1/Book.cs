using System;
using System.Collections.Generic;
using System.Text;

namespace ReadMore_Books_EFCore_Assignment_1
{

    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string ISBN { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int Pages { get; set; }
        public int PublishedYear { get; set; }
        public bool IsInStock { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;
    }
}
