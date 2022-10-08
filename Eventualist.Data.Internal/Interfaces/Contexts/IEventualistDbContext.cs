using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventualist.Data.Internal.Interfaces.Contexts
{
    public interface IEventualistDbContext
    {
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = new());
    }
}
