using Core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.IServices;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenresController : ControllerBase
    {
        public readonly IGenreService _genreService;

        public GenresController(IGenreService genreService)
        {
            _genreService = genreService;
        }

        [HttpPost]
        public async Task<IActionResult> AddGenre(Genre genre)
        {
            await _genreService.AddGenre(genre);
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> GetAllGenres()
        {
            var list = await _genreService.GetAllGenres();
            return Ok(list);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteGenre(int id)
        {
            await _genreService.DeleteGenre(id);
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> UpdateGenre(int id)
        {
            await _genreService.UpdateGenre(id);
            return Ok();
        }

    }
}
