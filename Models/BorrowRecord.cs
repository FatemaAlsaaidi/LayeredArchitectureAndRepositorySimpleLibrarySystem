using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayeredArchitectureAndRepositorySimpleLibrarySystem.Models
{
    public class BorrowRecord
    {
        // Represents a record of a book borrowed by a member
        public static int RecordCount { get; set; } = 0; // Static property to keep track of the number of borrow records
        public int RecordId { get; set; }
        public int MemberId { get; set; }
        public int BookId { get; set; }
        public DateTime BorrowDate { get; set; }
    }
}
