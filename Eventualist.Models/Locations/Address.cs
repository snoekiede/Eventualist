using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eventualist.Models.Common;

namespace Eventualist.Models.Locations
{
    public class Address:EventModel
    {
        public string Street { get; set; } = string.Empty;
        public string ZipCode { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;

        public string Region { get; set; } = string.Empty;
        public Country? Country { get; set; }
    }
}
