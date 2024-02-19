namespace GameTrackerAPI.Models
{
  public class UserRating
  {
    public int Id { get; set; }
    public int GameId { get; set; }
    public int UserId { get; set; }
    public float Rating { get; set; }
    public string GameTitle { get; set; }
  }
}
