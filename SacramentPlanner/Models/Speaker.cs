using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SacramentPlanner.Models
{
    public class Speaker
    {
        public int SpeakerID { get; set; }
        public int MembersID { get; set; }
        public string Topic { get; set; }
        public int MeetingId { get; set; }

        // Navigation Properties
        public Members Members { get; set; }
        public Meeting Meeting { get; set; }
    }
}
