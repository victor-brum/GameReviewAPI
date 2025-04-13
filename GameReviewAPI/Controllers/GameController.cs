﻿using GameReviewAPI.Interfaces;
using GameReviewAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace GameReviewAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : ControllerBase
    {
        private readonly IGameRepository _gameRepository;

        public GameController(IGameRepository gameRepository)
        {
            this._gameRepository = gameRepository;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Game>))]
        public IActionResult GetGames()
        {
            var games = _gameRepository.GetGames();

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(games);
        }
    }
}
