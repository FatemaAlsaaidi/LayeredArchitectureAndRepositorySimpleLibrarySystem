using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayeredArchitectureAndRepositorySimpleLibrarySystem.Repositories
{
    class BookRepository
    {
        //Method to load All books from a file
        public List<Models.Book> GetAllBooks()
        {
            // This method should return all books from the data source
            return FileContext.LoadDataFromFile<Models.Book>(FileContext.FileBookPath);
        }
       


    }
}
