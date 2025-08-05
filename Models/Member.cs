using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayeredArchitectureAndRepositorySimpleLibrarySystem.Models
{
    public class Member
    {
        // Properties a member in the library system
        public static int MemberCount { get; set; } = 0;
        public int MemberId { get; set; }
        public string MemberName { get; set; }
    }
}
