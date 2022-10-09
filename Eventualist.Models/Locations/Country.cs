using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eventualist.Models.Common;

namespace Eventualist.Models.Locations
{
    public class Country:EventModel
    {
        public string Name { get; set; } = string.Empty;
        public string Abbreviation { get; set; } = string.Empty;
    }
}
