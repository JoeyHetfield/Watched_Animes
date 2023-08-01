using Microsoft.AspNetCore.Mvc;
using watched_animes.Controllers;
using watched_animes.Database;
using watched_animes.Models;

namespace watched_animes.Controllers;
[ApiController]
[Route("[controller]")]
public class AnimeController : Controller
{
    private WatchedAnimesDatabase _database;
    public AnimeController(WatchedAnimesDatabase database)
    {
        _database = database;
    }
    [HttpGet]
    public IActionResult GetAnimes()
    {
        var animes = _database.GetAnimes();
        return Ok(animes);
    }

    [HttpPost]
    public IActionResult AddAnime([FromBody] Anime anime)
    {
        var newAnime = _database.AddAnime(anime);
        return Created("", newAnime);
    }

    [HttpPut("{id}")]
    public IActionResult UpdateAnime(int id, [FromBody] Anime anime)
    {
        var updatedAnime = _database.UpdateAnime(id, anime);
        return Ok(updatedAnime);
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteAnime(int id)
    {
        _database.DeleteAnime(id);
        return NoContent();
    }
}

