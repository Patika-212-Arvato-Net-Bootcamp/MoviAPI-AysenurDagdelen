using Core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.IServices;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        public readonly IMovieService _movieService;
        public readonly IGenreService _genreService;

        public MovieController(IMovieService movieService, IGenreService genreService)
        {
            _movieService = movieService;
            _genreService = genreService;
        }

        [HttpPost]
        public async Task<IActionResult> AddMovie(Movie movie)
        {
            await _movieService.AddMovie(movie);
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> GetMovieDetail(int id)
        {
            var list = await _movieService.GetMovieDetail(id);
            return Ok(list);
        }

        [HttpGet]
        public async Task<IActionResult> GetMoviesByGenre(int genreId)
        {
            var list = await _movieService.GetByGenreRepo(genreId);
            return Ok(list);
        }
    }
}
