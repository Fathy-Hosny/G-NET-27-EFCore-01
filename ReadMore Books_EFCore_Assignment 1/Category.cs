using System;
using System.Collections.Generic;
using System.Text;

namespace ReadMore_Books_EFCore_Assignment_1
{
    public class Category
    {
       
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public bool IsActive { get; set; }
    }


    }
