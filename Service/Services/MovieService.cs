using AutoMapper;
using Core.DTOs;
using Core.Models;
using Repository.IRepositories;
using Service.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class MovieService : IMovieService
    {
        public readonly IMovieRepository _movieRepository;
        public readonly IGenreRepository _genreRepository;
        public readonly IMapper _mapper;

        public MovieService(IMovieRepository movieRepository, IGenreRepository genreRepository, IMapper mapper)
        {
            _movieRepository = movieRepository;
            _genreRepository = genreRepository;
            _mapper = mapper;
        }

        public Task<MovieDTO> AddMovie(Movie movie)
        {
            throw new NotImplementedException();
        }

        public Task<Movie> DeleteMovie(int id)
        {
            throw new NotImplementedException();
        }

       
        public async Task<List<Movie>> GetAllMovies()
        {
            return await _movieRepository.GetAllAsync();
        }

        public Task<Movie> GetMovieDetail(int id)
        {
            throw new NotImplementedException();
        }
        public async Task<List<Movie>> GetAllGenre()
        {
            return await _movieRepository.GetAllAsync();
        }

        Task<List<GetMovieListDTO>> IMovieService.GetAllMovies()
        {
            throw new NotImplementedException();
        }
        

        public async Task<List<MovieDTO>> GetByGenre(int genreId)
        {
            var list = _movieRepository.GetByGenreRepo(genreId);
            var listDto = _mapper.Map<List<MovieDTO>>(list);
            return listDto;
        }

        public Task<List<GetMovieListDTO>> GetByGenreRepo(int genreId)
        {
            throw new NotImplementedException();
        }
    }
}
