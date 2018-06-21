using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace aspnetCoreReactTemplate.Models
{
    public class ApplicationUser: IdentityUser<Guid>
    {
        public string GivenName { get; set; }
    }
}
