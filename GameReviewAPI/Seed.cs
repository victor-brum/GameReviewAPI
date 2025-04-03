using GameReviewAPI.Data;
using GameReviewAPI.Models;

namespace GameReviewAPI
{
    public class Seed
    {
        private readonly DataContext dataContext;
        public Seed(DataContext context)
        {
            this.dataContext = context;
        }
        public void SeedDataContext()
        {
            if (!dataContext.gameCompanies.Any())
            {
                var gamePlayers = new List<GameCompany>()
                {
                    new GameCompany()
                    {
                        Game = new Game()
                        {
                            Name = "Super Mario Bros",
                            ReleaseDate = new DateTime(1985,9,13),
                            GameCategories = new List<GameCategory>()
                            {
                                new GameCategory { Category = new Category() { Name = "Arcade platforme"}}
                            },
                            Reviews = new List<Review>()
                            {
                                new Review { Title="Super Mario Bross",Text = "Super Mario Bros is a timeless classic! The smooth gameplay, challenging levels, and iconic soundtrack make this one of the greatest games of all time.", Rating = 5,
                                Reviewer = new Reviewer(){ FirstName = "Victor", LastName = "Brum" } },
                                new Review { Title="Super Mario Bross", Text = "Impossible not to love this game! The controls are responsive, the graphics are charming for its time, and the sense of progression is addictive. A true milestone in video game history!", Rating = 5,
                                Reviewer = new Reviewer(){ FirstName = "Milena", LastName = "Brum" } },
                                new Review { Title="Super Mario Bross",Text = "I don't get the hype. I found the game repetitive, the graphics outdated, and the difficulty frustrating. I just didn’t enjoy it.", Rating = 1,
                                Reviewer = new Reviewer(){ FirstName = "João", LastName = "Souza" } },
                            }
                        },
                        Company = new Company()
                        {
                            Name = "Nintendo",
                            Headquarters = new Headquarters()
                            {
                                City = "Kyoto",
                                Country = "Japan"
                            }
                        }
                    },
                    new GameCompany()
                    {
                        Game = new Game()
                        {
                            Name = "Metroid",
                            ReleaseDate = new DateTime(1986,8,6),
                            GameCategories = new List<GameCategory>()
                            {
                                new GameCategory { Category = new Category() { Name = "Action-adventure"}}
                            },
                            Reviews = new List<Review>()
                            {
                                new Review { Title= "Metroid", Text = "Metroid was revolutionary for its time! The open-world exploration, eerie atmosphere, and nonlinear gameplay made it a standout title. A true classic!", Rating = 5,
                                Reviewer = new Reviewer(){ FirstName = "Victor", LastName = "Brum" } },
                                new Review { Title= "Metroid",Text = "A fantastic adventure with great exploration. Some areas can be a bit frustrating due to the lack of a map, but it's still an amazing experience.", Rating = 5,
                                Reviewer = new Reviewer(){ FirstName = "Milena", LastName = "Brum" } },
                                new Review { Title= "Metroid", Text = "I appreciate the innovation, but the game feels too confusing without guidance. The backtracking got annoying after a while.", Rating = 1,
                                Reviewer = new Reviewer(){ FirstName = "João", LastName = "Souza" } },
                            }
                        },
                        Company = new Company()
                        {
                            Name = "Nintendo",
                            Headquarters = new Headquarters()
                            {
                                City = "Kyoto",
                                Country = "Japan"
                            }
                        }
                    },
                    new GameCompany()
                    {
                        Game = new Game()
                        {
                            Name = "Sonic the Hedgehog",
                            ReleaseDate = new DateTime(1986,02,21),
                            GameCategories = new List<GameCategory>()
                            {
                                new GameCategory { Category = new Category() { Name = "Arcade platforme"}}
                            },
                            Reviews = new List<Review>()
                            {
                                new Review { Title="Sonic the Hedgehog",Text = "Sonic was a game-changer! The fast-paced gameplay, vibrant graphics, and unforgettable soundtrack made this an instant classic. A must-play for platformer fans!", Rating = 5,
                                Reviewer = new Reviewer(){ FirstName = "Victor", LastName = "Brum" } },
                                new Review { Title="Sonic the Hedgehog",Text = "The speed and momentum-based gameplay set Sonic apart from other platformers. Some levels can be a bit tricky, but it's still an exciting and fun experience.", Rating = 5,
                                Reviewer = new Reviewer(){ FirstName = "Milena", LastName = "Brum" } },
                                new Review { Title="Sonic the Hedgehog",Text = "I never really liked Sonic’s gameplay style. The high-speed mechanics often led to unfair hits, and the level design sometimes felt frustrating.", Rating = 1,
                                Reviewer = new Reviewer(){ FirstName = "João", LastName = "Souza" } },
                            }
                        },
                        Company = new Company()
                        {
                            Name = "Sega",
                            Headquarters = new Headquarters()
                            {
                                City = "Tokyo",
                                Country = "Japan"
                            }
                        }
                    }
                };
                dataContext.gameCompanies.AddRange(gamePlayers);
                dataContext.SaveChanges();
            }
        }
    }
}
