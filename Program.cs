using ReadMoreBooks.Data;
using ReadMoreBooks.Models;

namespace ReadMoreBooks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using BookstoreDbContext context = new BookstoreDbContext();

            Author author = new Author
            {
                FirstName = "Robert",
                LastName = "Martin",
                Email = "unclebob@cleancode.com",
                Biography = "Software engineer and author.",
                DateOfBirth = new DateTime(1952, 12, 5)
            };

            Category category = new Category
            {
                Name = "Programming",
                Description = "Software development and coding books",
                IsActive = true
            };

            Book book = new Book
            {
                Title = "Clean Code",
                ISBN = "9780132350884",
                Price = 45.50m,
                NumberOfPages = 464,
                PublishedYear = 2008,
                IsInStock = true,
                Author = author,
                Category = category
            };

            context.Books.Add(book);
            context.SaveChanges();

            Console.WriteLine("Database created and data saved successfully!");
        }
    }
}