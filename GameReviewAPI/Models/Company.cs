namespace GameReviewAPI.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public Headquarters? Headquarters { get; set; }
        public ICollection<GameCompany>? GameCompanies { get; set; }
    }
}
