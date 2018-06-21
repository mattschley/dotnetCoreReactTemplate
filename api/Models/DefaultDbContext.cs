using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace aspnetCoreReactTemplate.Models
{
  public class DefaultDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, Guid>
  {
    public DefaultDbContext(DbContextOptions<DefaultDbContext> options)
      : base(options)
    {
    }

    public DbSet<ApplicationUser> ApplicationUsers { get; set; }
    public DbSet<Contact> Contacts { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);

      foreach(var entity in modelBuilder.Model.GetEntityTypes())
      {
        // Remove 'AspNet' prefix and convert table name from PascalCase to snake_case. E.g. AspNetRoleClaims -> role_claims
        entity.Relational().TableName = entity.Relational().TableName.Replace("AspNet", "");

      }
      
    }

  }
}
