namespace GameTrackerAPI.Models
{
  public class Backlog
  {
    public int Id { get; set; }
    public int GameId { get; set; }
    public int? UserId { get; set; }
    public string? GameTitle { get; set; }
  }
}
