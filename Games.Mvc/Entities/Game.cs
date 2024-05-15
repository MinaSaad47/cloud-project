namespace Games.Mvc.Entities;

public class Game
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string Description { get; set; }
    public required string Url { get; set; }
    public required string PictureUrl { get; set; }
}