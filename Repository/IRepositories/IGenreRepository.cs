using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.IRepositories
{
    public interface IGenreRepository : IGenericRepository<Genre>
    {
        Task<Genre> AddGenre(Genre genre);
    }
}
