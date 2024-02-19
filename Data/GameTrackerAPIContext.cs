using GameTrackerAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace GameTrackerAPI.Data
{
  public class GameTrackerAPIContext : DbContext
  {
    public GameTrackerAPIContext(DbContextOptions<GameTrackerAPIContext> options)
      : base(options) { }

    public DbSet<Backlog> Backlogs { get; set; }
    public DbSet<UserRating> UserRatings { get; set; }
  }
}
