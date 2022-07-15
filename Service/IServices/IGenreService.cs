using Core.DTOs;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.IServices
{
    public interface IGenreService
    {
        Task<List<Genre>> GetAllGenres();
        Task<Genre> AddGenre(Genre genre);
        Task DeleteGenre(int id);
        Task UpdateGenre(int id);
    }
}
