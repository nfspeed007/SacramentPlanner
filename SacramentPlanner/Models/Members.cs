using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SacramentPlanner.Models
{
    public enum Calling
    {
        Bishop,
        Councilor_In_Bishopric,
        Relief_Society_President,
        Elders_Quorum_President,
        Primary_President,
        Young_Mens_President,
        Young_Womens_President,
        Other,
        No_Calling
    }

    public class Members
    {

        public int MembersID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Calling? Calling { get; set; }
    }
}
