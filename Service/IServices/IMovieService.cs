using Core.DTOs;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.IServices
{
    public interface IMovieService
    {
        Task<List<GetMovieListDTO>> GetAllMovies();
        Task<Movie> GetMovieDetail(int id);
        Task<MovieDTO> AddMovie(Movie movie);
        Task<List<MovieDTO>> GetByGenre(int genreId);
        Task<List<GetMovieListDTO>> GetByGenreRepo(int genreId);
    }
}
