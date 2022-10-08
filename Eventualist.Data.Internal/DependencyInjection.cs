using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eventualist.Data.Internal.Contexts;
using Eventualist.Data.Internal.Interfaces.Contexts;
using Eventualist.Data.Internal.Interfaces.Services;
using Eventualist.Data.Internal.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Eventualist.Data.Internal
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDataAccess(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddScoped<ICurrentUserService, CurrentUserService>();
            services.AddScoped<IEventualistDbContext>(provider => provider.GetService<EventualistContext>()!);

            services.AddDbContext<EventualistContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            return services;
        }
    }
}
