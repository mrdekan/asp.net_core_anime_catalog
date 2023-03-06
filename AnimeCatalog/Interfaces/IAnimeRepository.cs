﻿using AnimeCatalog.Models;

namespace AnimeCatalog.Interfaces
{
	public interface IAnimeRepository
	{
		Task<IEnumerable<Anime>> GetAll();
		Task<Anime> GetByIdAsync(int id);
		Task<Anime> GetByIdAsyncNoTracking(int id);
		bool Add(Anime club);
		bool Update(Anime club);
		bool Delete(Anime club);
		Task<IEnumerable<Anime>> GetAnimeByTag(string tag);
		bool Save();
	}
}
