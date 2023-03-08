using AnimeCatalog.Models;
using Microsoft.AspNetCore.Identity;
using System.Diagnostics;
using System.Net;
using System.Xml.Linq;

namespace AnimeCatalog.Data
{
	public class Seed
	{
		public static void SeedData(IApplicationBuilder applicationBuilder)
		{
			using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
			{
				var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();

				context.Database.EnsureCreated();

				if (!context.Animes.Any())
				{
					context.Animes.AddRange(new List<Anime>()
					{
						new Anime()
						{
							Name = "Dagashi Kashi",
							Description = "The Dagashi Kashi anime loosely follows the plot of the manga, where in any order tells the life of Kokonotsu Shikada living in the countryside. It all started from an argument between his father, Yō Shikada who wanted him to become the successor of the family business about candy.",
							Views = 788,
							Mark = 9.3f,
							Image = "https://m.media-amazon.com/images/M/MV5BYzIwMTc0MTktODVjYS00YmMzLWJmYzItNTc1ZjBiZDkyM2EwXkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_FMjpg_UX1000_.jpg",
							SeeasonsAndSeries = "12",
							Tags = "short comedy everyday_life",
                            SeriesURL = "https://res.cloudinary.com/draodt7we/video/upload/v1678260940/file_example_MP4_640_3MG_wndezm.mp4",
                        },
						new Anime()
						{
							Name = "Steins; Gate",
							Description = "Steins;Gate is a Japanese anime television series created by the animation studio White Fox based on 5pb. and Nitroplus's 2009 visual novel of the same name.",
							Views = 1322,
							Mark = 9.3f,
							Image = "https://upload.wikimedia.org/wikipedia/en/e/e4/Steins%3BGate_cover_art.jpg",
							SeeasonsAndSeries = "25 24",
                            Tags = "drama fantastic thriller psychology",
                            SeriesURL = "https://res.cloudinary.com/draodt7we/video/upload/v1678260940/file_example_MP4_640_3MG_wndezm.mp4",
                        },
						new Anime()
						{
							Name = "My hero academia",
							Description = "My Hero Academia (Japanese: 僕のヒーローアカデミア, Hepburn: Boku no Hīrō Akademia) is a Japanese superhero manga series written and illustrated by Kōhei Horikoshi.",
							Views = 1765,
							Mark = 9.2f,
							Image = "https://upload.wikimedia.org/wikipedia/en/5/5a/Boku_no_Hero_Academia_Volume_1.png",
							SeeasonsAndSeries = "13 25 25 25 25 22",
                            Tags = "long adventures action school fantastic",
                            SeriesURL = "https://res.cloudinary.com/draodt7we/video/upload/v1678260940/file_example_MP4_640_3MG_wndezm.mp4",
                        },
                        new Anime()
                        {
                            Name = "Call of the Night",
                            Description = "Call of the Night is a Japanese manga series written and illustrated by Kotoyama.",
                            Views = 685,
                            Mark = 9.42f,
                            Image = "http://res.cloudinary.com/draodt7we/image/upload/v1678217009/mloo02ygej4uhycfmgb4.jpg",
                            SeeasonsAndSeries = "13",
                            Tags = "romance short mystic",
                            SeriesURL = "https://res.cloudinary.com/draodt7we/video/upload/v1678260940/file_example_MP4_640_3MG_wndezm.mp4",
                        },
                        new Anime()
                        {
                            Name = "Re:Zero",
                            Description = "Re:Zero − Starting Life in Another World is an anime adaptation of a light novel series written by Tappei Nagatsuki and illustrated by Shinichirou Otsuka.",
                            Views = 981,
                            Mark = 9.2f,
                            Image = "http://res.cloudinary.com/draodt7we/image/upload/v1678215617/mdh8wygbhehrfsl7x1u7.jpg",
                            SeeasonsAndSeries = "25 25",
                            Tags = "drama fantastic thriller psychology",
                            SeriesURL = "https://res.cloudinary.com/draodt7we/video/upload/v1678260940/file_example_MP4_640_3MG_wndezm.mp4",
                        },
                        new Anime()
                        {
                            Name = "Chainsaw Man",
                            Description = "Chainsaw Man (Japanese: チェンソーマン, Hepburn: Chensō Man) is a Japanese manga series written and illustrated by Tatsuki Fujimoto.",
                            Views = 1022,
                            Mark = 9.6f,
                            Image = "http://res.cloudinary.com/draodt7we/image/upload/v1678259191/m81qnrppboljnvezmdpw.jpg",
                            SeeasonsAndSeries = "12",
                            Tags = "action short mystic",
                            SeriesURL = "https://res.cloudinary.com/draodt7we/video/upload/v1678260940/file_example_MP4_640_3MG_wndezm.mp4",
                        },
                    });
					context.SaveChanges();
				}
			}
		}
	}
}
