using Core.DTOs;
using Core.Models;
using Repository.IRepositories;
using Service.IServices;
using Repository; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class GenreService : IGenreService
    {
        public readonly IGenreRepository _genreRepository;
        private readonly AppDbContext _appDbContext;
        public GenreService(IGenreRepository genreRepository, AppDbContext appDbContext)
        {
            _genreRepository = genreRepository;
            _appDbContext = appDbContext;
        }

        public async Task<Genre> AddGenre(Genre genre)
        {
            return await _genreRepository.AddGenre(genre);
            await _appDbContext.SaveChangesAsync();
        }


        public async Task<List<Genre>> GetAllGenres()
        {
            return await _genreRepository.GetAllAsync();
        }

        public Task UpdateGenre(int id)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteGenre(int id)
        {
            var genre = await _genreRepository.GetByIdAsync(id);
            await _genreRepository.RemoveAsync(genre);
        }
    }
}
