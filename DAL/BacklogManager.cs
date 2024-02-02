﻿using GameTrackerAPI.Data;
using GameTrackerAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace GameTrackerAPI.DAL
{
    public class BacklogManager
    {
        private readonly GameTrackerAPIContext _context;

        public BacklogManager(GameTrackerAPIContext context)
        {
            _context = context;
        }
        public async Task<List<Backlog>> GetAllBacklogGames()
        {
            List<Backlog> backlogs = await _context.Backlogs.ToListAsync();

            return backlogs;
        }

        public async Task AddGameToBacklog(Backlog backlog)
        {
            await _context.Backlogs.AddAsync(backlog);
            await _context.SaveChangesAsync();
        }

        public static implicit operator BacklogManager(GameTrackerAPIContext context)
        {
            return new BacklogManager(context);
        }
    }
}
