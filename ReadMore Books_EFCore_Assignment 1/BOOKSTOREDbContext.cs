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
                .UseSqlServer("Server=.;Database=BOOKSTORE;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet <Author> Authors { get; set; }
         public DbSet<Book> Books { get; set; }
        public DbSet<BookAuthor> BookAuthors { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookAuthor>()
                .HasKey(ba => new { ba.BookId, ba.AuthorId });
        }
    }
}
