using LayeredArchitectureAndRepositorySimpleLibrarySystem.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayeredArchitectureAndRepositorySimpleLibrarySystem.Services
{
    class LibraryService
    {
        // 
        public void AddBook(string title, string author, bool isAvailable)
        {
            // Create a new book instance
            var newBook = new Models.Book
            {
                BookId = ++Models.Book.BookCount,
                BookTitle = title,
                BookAuthor = author,
                IsAvailable = isAvailable
            };
            // bookRepo.AddBook(newBook);
            Console.WriteLine($"Book '{newBook.BookTitle}' by {newBook.BookAuthor} added successfully.");
        }
    }
}
