using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SacramentPlanner.Models
{
    public class Meeting
    {
        public int Id { get; set; }
        
        public DateTime Date { get; set; }
        public Members Conductor { get; set; }
        public string OpeningSong { get; set; }
        public Members OpeningPrayer { get; set; }

        public string SacramentSong { get; set; }

        public string ClosingSong { get; set; }
        public Members ClosingPrayer { get; set; }
    }
}