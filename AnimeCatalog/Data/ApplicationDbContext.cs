using AnimeCatalog.Models;
using Microsoft.EntityFrameworkCore;

namespace AnimeCatalog.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{

		}
		public DbSet<Anime> Animes { get; set; }
	}
}
