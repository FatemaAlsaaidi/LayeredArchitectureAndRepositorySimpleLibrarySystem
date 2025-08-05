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
    }
}
