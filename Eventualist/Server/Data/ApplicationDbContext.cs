using Duende.IdentityServer.EntityFramework.Options;
using Eventualist.Data.Internal.Models;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Eventualist.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<EventualistUser>
    {
        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }
    }
}