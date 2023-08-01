namespace watched_animes.Models;

public class Anime
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public bool IsWatched { get; set; }

    public string? Genre { get; set; }

}