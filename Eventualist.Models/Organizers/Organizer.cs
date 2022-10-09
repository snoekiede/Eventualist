using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eventualist.Data.Internal.Models;
using Eventualist.Models.Common;

namespace Eventualist.Models.Organizers
{
    public class Organizer:EventModel
    {
        public string? Name { get; set; }
        public bool IsBusiness { get; set; } = false;

        public EventualistUser User { get; set; }

        
    }
}
