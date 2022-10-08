using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Duende.IdentityServer.EntityFramework.Options;
using Eventualist.Data.Internal.Interfaces.Contexts;
using Eventualist.Data.Internal.Interfaces.Services;
using Eventualist.Data.Internal.Models;
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
    }
}
