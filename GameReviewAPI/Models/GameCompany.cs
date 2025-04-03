namespace GameReviewAPI.Models
{
    public class GameCompany
    {
        public int GameId { get; set; }
        public int CompanyId { get; set; }
        public Game? Game { get; set; }
        public Company? Company { get; set; }
    }
}
