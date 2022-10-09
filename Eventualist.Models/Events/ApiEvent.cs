using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eventualist.Models.Common;
using Eventualist.Models.Locations;
using Eventualist.Models.Organizers;

namespace Eventualist.Models.Events
{
    public class ApiEvent:EventModel
    {
        public bool Approved { get; set; }
        public bool Active { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool AllDay { get; set; } = false;
        public virtual List<EventLocation> Locations { get; set; } = new();
        public Organizer? Organizer { get; set; }


    }
}
