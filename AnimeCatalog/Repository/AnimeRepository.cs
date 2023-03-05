using AnimeCatalog.Data;
using AnimeCatalog.Interfaces;
using AnimeCatalog.Models;
using Microsoft.EntityFrameworkCore;

namespace AnimeCatalog.Repository
{
	public class AnimeRepository : IAnimeRepository
	{
		public ApplicationDbContext _context { get; set; }
		public AnimeRepository(ApplicationDbContext context)
		{
			_context = context;
		}
		public bool Add(Anime club)
		{
			_context.Add(club);
			return Save();
		}

		public bool Delete(Anime anime)
		{
			_context.Remove(anime);
			return Save();
		}

		public async Task<IEnumerable<Anime>> GetAll()
		{
			return await _context.Animes.ToListAsync();
		}

		public async Task<Anime> GetByIdAsync(int id)
		{
			return await _context.Animes.FirstOrDefaultAsync(i => i.Id == id);
		}
		public async Task<Anime> GetByIdAsyncNoTracking(int id)
		{
			return await _context.Animes.AsNoTracking().FirstOrDefaultAsync(i => i.Id == id);
		}

		public bool Save()
		{
			var saved = _context.SaveChanges();
			return saved > 0 ? true : false;
		}

		public bool Update(Anime anime)
		{
			_context.Update(anime);
			return Save();
		}
	}
}
