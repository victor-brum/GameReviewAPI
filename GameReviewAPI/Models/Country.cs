﻿namespace GameReviewAPI.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public ICollection<Player>? Players { get; set; }
    }
}
