using System;
using Microsoft.AspNetCore.Identity;

namespace aspnetCoreReactTemplate.Models
{
    public class ApplicationUser: IdentityUser<Guid>
    {
        public string GivenName { get; set; }
    }
}
