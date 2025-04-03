namespace GameReviewAPI.Models
{
    public class Headquarters
    {
        public int Id { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
        public ICollection<Company>? Companies { get; set; }
    }
}
