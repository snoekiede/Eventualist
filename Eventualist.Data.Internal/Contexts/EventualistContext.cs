using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Duende.IdentityServer.EntityFramework.Options;
using Eventualist.Data.Internal.Interfaces.Contexts;
using Eventualist.Data.Internal.Interfaces.Services;
using Eventualist.Data.Internal.Models;
using Eventualist.Models.Common;
using Eventualist.Models.Events;
using Eventualist.Models.Locations;
using Eventualist.Models.Organizers;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Eventualist.Data.Internal.Contexts
{
    public class EventualistContext:ApiAuthorizationDbContext<EventualistUser>,IEventualistDbContext
    {
        private readonly ICurrentUserService currentUserService;

        public EventualistContext(DbContextOptions<EventualistContext> options,
            IOptions<OperationalStoreOptions> storeOptions,
            ICurrentUserService service):base(options,storeOptions)
        {
            this.currentUserService = service;
        }

        public EventualistContext(DbContextOptions<EventualistContext> options,
            IOptions<OperationalStoreOptions> storeOptions) : base(options,storeOptions)
        {

        }

        //The data

        //Events
        public DbSet<ApiEvent> Events { get; set; }
        //Locations
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<EventLocation> Locations { get; set; }

        //Organizers
        public DbSet<Organizer> Organizers { get; set; }

        public override Task<int> SaveChangesAsync(CancellationToken token = new())
        {
            foreach (var entry in ChangeTracker.Entries<AuditableModel>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedBy = this.currentUserService.UserId;
                        break;
                    case EntityState.Modified:
                        entry.Entity.ModifiedBy = this.currentUserService.UserId;
                        entry.Entity.Modified = DateTime.Now;
                        break;
                    default:
                        break;
                }
            }

            return base.SaveChangesAsync(token);
        }
    }
}
