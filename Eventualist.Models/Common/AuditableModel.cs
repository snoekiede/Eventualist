using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventualist.Models.Common
{
    public class AuditableModel:Model
    {
        public string? CreatedBy { get; set; } = null;
        public DateTime Created { get; } = DateTime.Now;
        public string? ModifiedBy { get; set; } = null;
        public DateTime? Modified { get; set; } = null;
    }
}
