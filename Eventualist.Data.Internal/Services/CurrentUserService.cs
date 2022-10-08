using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Eventualist.Data.Internal.Interfaces.Services;
using Microsoft.AspNetCore.Http;

namespace Eventualist.Data.Internal.Services
{
    public class CurrentUserService:ICurrentUserService
    {
        public string? UserId { get; }

        public CurrentUserService(IHttpContextAccessor httpContextAccessor)
        {
            this.UserId = httpContextAccessor.HttpContext?.User?.FindFirstValue(ClaimTypes.NameIdentifier);
        }
    }
}
