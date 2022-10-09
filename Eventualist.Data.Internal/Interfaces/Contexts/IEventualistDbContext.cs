using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eventualist.Models.Events;
using Eventualist.Models.Locations;
using Eventualist.Models.Organizers;
using Microsoft.EntityFrameworkCore;

namespace Eventualist.Data.Internal.Interfaces.Contexts
{
    public interface IEventualistDbContext
    {
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = new());

        //The data

        //Events
        DbSet<ApiEvent> Events { get; set; }
        //Locations
        DbSet<Address> Addresses { get; set; }
        DbSet<Country> Countries { get; set; }
        DbSet<EventLocation> Locations { get; set; }

        //Organizers
        DbSet<Organizer> Organizers { get; set; }
    }
}
