using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SacramentPlanner.Models
{
    public enum Calling
    {
        Bishop,
        [Display(Name = "Councilor in Bishopric")]
        Councilor_In_Bishopric,
        [Display(Name = "Elders Quorum President")]
        Elders_Quorum_President,
        [Display(Name = "Relief Society President")]
        Relief_Society_President,
        [Display(Name = "Young Mens President")]
        Young_Mens_President,
        [Display(Name = "Young Womens President")]
        Young_Womens_President,
        [Display(Name = "Primary President")]
        Primary_President,
        Other,
        [Display(Name = "No Calling")]
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
