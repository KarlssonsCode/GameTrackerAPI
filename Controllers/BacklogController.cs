﻿using GameTrackerAPI.DAL;
using GameTrackerAPI.Data;
using GameTrackerAPI.Models;
using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GameTrackerAPI.Controllers
{
  [Route("Backlog")]
  [ApiController]
  public class BacklogController : ControllerBase
  {
    private readonly BacklogManager _backlogManager;

    public BacklogController(GameTrackerAPIContext context)
    {
      _backlogManager = context;
    }

    [HttpGet("GetBacklogGames")]
    public async Task<IEnumerable<Backlog>> GetBacklogGames()
    {
      var backlogGames = await _backlogManager.GetAllBacklogGames();
      return backlogGames;
    }

    [HttpPost("AddBacklogGames")]
    public async Task Post([FromBody] Backlog backlog)
    {
      await _backlogManager.AddGameToBacklog(backlog);
    }

    [HttpDelete("DeleteBacklogGame/{GameId}")]
    public async Task<IActionResult> RemoveBacklogGame(int gameId)
    {
      try
      {
        await _backlogManager.DeleteBacklogGame(gameId);
        return Ok();
      }
      catch (Exception ex)
      {
        return StatusCode(500, $"Internal server error: {ex.Message}");
      }
    }
  }
}
