using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.EntityFrameworkCore;
using ReadMoreBooks.Models;

namespace ReadMoreBooks.Data
{
    internal class BookstoreDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=ReadMoreBooksDb;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
