﻿using GameReviewAPI.Data;
using GameReviewAPI.Interfaces;
using GameReviewAPI.Models;

namespace GameReviewAPI.Repository
{
    public class GameRepository : IGameRepository
    {
        private readonly DataContext _context;

        public GameRepository(DataContext context)
        {
            _context = context;
        }

        public ICollection<Game> GetGames()
        {
            return _context.Games.OrderBy(g => g.Id).ToList();
        }
    }
}
