using Microsoft.AspNetCore.Mvc;
using SpeedJamLeaderboardAPI.Models;
using SpeedJamLeaderboardAPI.Services;

namespace SpeedJamLeaderboardAPI.Controllers;

[ApiController]
[Route("/[controller]")]
public class LeaderboardController : ControllerBase
{
    private readonly LeaderboardServices _leaderboardServices;


    public LeaderboardController(LeaderboardServices leaderboardServices) =>
        _leaderboardServices = leaderboardServices;

    // GET: api/Scores
    [HttpGet]
    public async Task<List<LeaderboardEntry>> Get() =>
        await _leaderboardServices.GetAsync();

    // GET: api/Scores/5
    [HttpGet("{id:length(24)}")]
    public async Task<ActionResult<LeaderboardEntry>> Get(string id)
    {
        var book = await _leaderboardServices.GetAsync(id);

        if (book is null)
        {
            return NotFound();
        }

        return book;
    }


    // POST: api/Score
    [HttpPost]
    public async Task<IActionResult> Post(LeaderboardEntry newLeaderboardEntry)
    {
        await _leaderboardServices.CreateAsync(newLeaderboardEntry);

        return CreatedAtAction(nameof(Get), new { id = newLeaderboardEntry.Id }, newLeaderboardEntry);
    }

    // PUT: api/Score/5
    [HttpPut("{id:length(24)}")]
    public async Task<IActionResult> Update(string id, LeaderboardEntry updatedLeaderboardEntry)
    {
        var book = await _leaderboardServices.GetAsync(id);

        if (book is null)
        {
            return NotFound();
        }

        updatedLeaderboardEntry.Id = book.Id;

        await _leaderboardServices.UpdateAsync(id, updatedLeaderboardEntry);

        return NoContent();
    }

    [HttpDelete("{id:length(24)}")]
    public async Task<IActionResult> Delete(string id)
    {
        var book = await _leaderboardServices.GetAsync(id);

        if (book is null)
        {
            return NotFound();
        }

        await _leaderboardServices.RemoveAsync(id);

        return NoContent();
    }
}