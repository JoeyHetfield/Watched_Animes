using watched_animes.Models;
namespace watched_animes.Database;

public class WatchedAnimesDatabase : IWatchedAnimeInterface
{
    private List<Anime> animes = new List<Anime>();
    public Anime AddAnime(Anime anime)
    {
        int nextAnimeId = animes.Count() + 1;
        anime.Id = nextAnimeId;
        animes.Add(anime);
        return anime;
    }

    public void DeleteAnime(int id)
    {
        int index = animes.FindIndex(anime => anime.Id == id);
        animes.RemoveAt(index);
    }

    public Anime UpdateAnime(int id, Anime anime)
    {
        int index = animes.FindIndex(anime => anime.Id == id);
        if (index > -1)
        {
            animes[index].Name = anime.Name;
            return animes[index];
        }
        return null;
    }

    public List<Anime> GetAnimes()
    {
        return animes;
    }
}