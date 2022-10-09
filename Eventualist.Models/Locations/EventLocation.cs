using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eventualist.Models.Common;

namespace Eventualist.Models.Locations
{
    public class EventLocation:EventModel
    {
        public string? VenueName { get; set; }
        public string? Description { get; set; }
        public string? URL { get; set; }
        public Address? Address { get; set; }
    }
}
