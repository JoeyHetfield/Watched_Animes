using watched_animes.Models;
namespace watched_animes.Database;
public interface IWatchedAnimeInterface
{
    Anime AddAnime(Anime anime);

    void DeleteAnime(int id);

    Anime UpdateAnime(int id, Anime anime);

    List<Anime> GetAnimes();
}
