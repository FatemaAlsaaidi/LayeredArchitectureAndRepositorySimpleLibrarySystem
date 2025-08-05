using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayeredArchitectureAndRepositorySimpleLibrarySystem.Models
{
    public class Book
    {
        // properties a book in the library system
        public static int BookCount { get; set; } = 0;
        public int BookId { get; set; }
        public string BookTitle { get; set; }
        public string BookAuthor { get; set; }
        public bool IsAvailable { get; set; }
    }
}
