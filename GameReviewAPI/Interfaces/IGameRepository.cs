using GameReviewAPI.Models;

namespace GameReviewAPI.Interfaces
{
    public interface IGameRepository
    {
        ICollection<Game> GetGames();
    }
}
