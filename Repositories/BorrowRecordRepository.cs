using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayeredArchitectureAndRepositorySimpleLibrarySystem.Repositories
{
    class BorrowRecordRepository
    {
        //method to return all borrow records from the data source
        public List<Models.BorrowRecord> GetAllBorrowRecords()
        {
            return FileContext.LoadDataFromFile<Models.BorrowRecord>(FileContext.FileBorrowRecordPath);
        }

        // Method to add a new borrow record
        public void BorrowBook(Models.BorrowRecord borrowRecord)
        {
            // Load existing borrow records
            var borrowRecords = GetAllBorrowRecords();
            // Add the new borrow record to the list
            borrowRecords.Add(borrowRecord);
            // Save the updated list back to the file
            FileContext.SaveDataToFile(borrowRecords, FileContext.FileBorrowRecordPath);
        }

    }
}
