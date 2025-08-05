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
        public List<Models.Member> GetAllMember()
        {
            return FileContext.LoadDataFromFile<Models.Member>(FileContext.FileMembersPath);

        }

        // Methos for add new member 
        public void AddMember(Models.Member member)
        {
            // Load existing members
            var members = GetAllMember();
            // Add the new member to the list
            members.Add(member);
            // Save the updated list back to the file
            FileContext.SaveDataToFile(members, FileContext.FileMembersPath);
        }
    }
}
