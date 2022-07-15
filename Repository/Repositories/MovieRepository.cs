using Core.Models;
using Microsoft.EntityFrameworkCore;
using Repository.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class MovieRepository : GenericRepository<Movie>, IMovieRepository
    {
        private readonly AppDbContext _appDbContext;
        public MovieRepository(AppDbContext appDbContext) : base(appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<List<Movie>> GetByGenreRepo(int genreId)
        {
            var genre = _appDbContext.Genres.Find(genreId);
            var movieList = await _appDbContext.Movies.Where(x => x.genres.Contains(genre)).ToListAsync();
            return movieList;
        }

        Task IMovieRepository.GetByGenreRepo(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
