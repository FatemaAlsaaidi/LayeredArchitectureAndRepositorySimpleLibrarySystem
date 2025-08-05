using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayeredArchitectureAndRepositorySimpleLibrarySystem.Repositories
{
    class MemberRepository
    {
        // method for return all members from the data source
        public List<Models.Book> GetAllMember()
        {
            return FileContext.LoadDataFromFile<Models.Book>(FileContext.FileMembersPath);

        }
    }
}
