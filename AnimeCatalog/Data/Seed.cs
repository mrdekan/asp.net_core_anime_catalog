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
						},
						new Anime()
						{
							Name = "Steins; Gate",
							Description = "Lorem ipsum",
							Views = 1322,
							Mark = 9.3f,
							Image = "https://upload.wikimedia.org/wikipedia/en/e/e4/Steins%3BGate_cover_art.jpg",
							SeeasonsAndSeries = "25 24",
						},
						new Anime()
						{
							Name = "My hero academia",
							Description = "Lorem ipsum",
							Views = 1765,
							Mark = 9.2f,
							Image = "https://upload.wikimedia.org/wikipedia/en/5/5a/Boku_no_Hero_Academia_Volume_1.png",
							SeeasonsAndSeries = "13 25 25 25 25 22",
						},
						new Anime()
						{
							Name = "Dagashi Kashi",
							Description = "The Dagashi Kashi anime loosely follows the plot of the manga, where in any order tells the life of Kokonotsu Shikada living in the countryside. It all started from an argument between his father, Yō Shikada who wanted him to become the successor of the family business about candy.",
							Views = 788,
							Mark = 9.3f,
							Image = "https://m.media-amazon.com/images/M/MV5BYzIwMTc0MTktODVjYS00YmMzLWJmYzItNTc1ZjBiZDkyM2EwXkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_FMjpg_UX1000_.jpg",
							SeeasonsAndSeries = "12",
						},
						new Anime()
						{
							Name = "Steins; Gate",
							Description = "Lorem ipsum",
							Views = 1322,
							Mark = 9.3f,
							Image = "https://upload.wikimedia.org/wikipedia/en/e/e4/Steins%3BGate_cover_art.jpg",
							SeeasonsAndSeries = "25 24",
						},
						new Anime()
						{
							Name = "My hero academia",
							Description = "Lorem ipsum",
							Views = 1765,
							Mark = 9.2f,
							Image = "https://upload.wikimedia.org/wikipedia/en/5/5a/Boku_no_Hero_Academia_Volume_1.png",
							SeeasonsAndSeries = "13 25 25 25 25 22",
						},
						new Anime()
						{
							Name = "Dagashi Kashi",
							Description = "The Dagashi Kashi anime loosely follows the plot of the manga, where in any order tells the life of Kokonotsu Shikada living in the countryside. It all started from an argument between his father, Yō Shikada who wanted him to become the successor of the family business about candy.",
							Views = 788,
							Mark = 9.3f,
							Image = "https://m.media-amazon.com/images/M/MV5BYzIwMTc0MTktODVjYS00YmMzLWJmYzItNTc1ZjBiZDkyM2EwXkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_FMjpg_UX1000_.jpg",
							SeeasonsAndSeries = "12",
						},
						new Anime()
						{
							Name = "Steins; Gate",
							Description = "Lorem ipsum",
							Views = 1322,
							Mark = 9.3f,
							Image = "https://upload.wikimedia.org/wikipedia/en/e/e4/Steins%3BGate_cover_art.jpg",
							SeeasonsAndSeries = "25 24",
						},
						new Anime()
						{
							Name = "My hero academia",
							Description = "Lorem ipsum",
							Views = 1765,
							Mark = 9.2f,
							Image = "https://upload.wikimedia.org/wikipedia/en/5/5a/Boku_no_Hero_Academia_Volume_1.png",
							SeeasonsAndSeries = "13 25 25 25 25 22",
						},
					});
					context.SaveChanges();
				}
			}
		}
	}
}
