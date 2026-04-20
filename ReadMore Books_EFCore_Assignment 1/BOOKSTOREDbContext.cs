using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace ReadMore_Books_EFCore_Assignment_1
{
    public class BOOKSTOREDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer("Server=.;Database=EfCore_BOOKSTORE;Trusted_Connection=True; trustServerCertificate=True;");
        }

    }
}
