using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventualist.Models.Common
{
    public class EventModel:AuditableModel
    {
        public Guid ObjectId { get; init; }

        public EventModel()
        {
            this.ObjectId = Guid.NewGuid();
        }
    }
}
