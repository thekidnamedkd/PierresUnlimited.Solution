using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Bakery.Models
{
public class BakeryContext : IdentityDbContext<User>
{
  public virtual DbSet<Treat> Treats { get; set; }
  public DbSet<Flavor> Flavors { get; set; }
  public DbSet<FlavorTreat> FlavorTreats { get; set; }
  public BakeryContext(DbContextOptions options) : base(options) { }
  }
}