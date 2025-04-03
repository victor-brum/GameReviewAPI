namespace GameReviewAPI.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Company { get; set; }
        public DateTime ReleaseDate { get; set; }
        public ICollection<Review>? Reviews { get; set; }
        public ICollection<GameCompany>? GameCompanies { get; set; }
        public ICollection<GameCategory>? GameCategories { get; set; }
    }
}
