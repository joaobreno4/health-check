using Microsoft.EntityFrameworkCore;

namespace RocketseatAPI.Infrastructure;

public class RocketseatDbContext : DbContext
{
    public RocketseatDbContext(DbContextOptions<RocketseatDbContext> options) : base(options) { }
}
