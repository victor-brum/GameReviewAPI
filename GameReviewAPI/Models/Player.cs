namespace GameReviewAPI.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int MyProperty { get; set; }
        public Country? Country { get; set; }
        public ICollection<GamePlayer>? Players { get; set; }
    }
}
