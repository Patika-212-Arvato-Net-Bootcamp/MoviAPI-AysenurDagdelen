using Core.Models;
using Repository.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class GenreRepository : GenericRepository<Genre>, IGenreRepository
    {
        private readonly AppDbContext _appDbContext;
        public GenreRepository(AppDbContext appDbContext) : base(appDbContext)
        {
            _appDbContext = appDbContext;
        }
    }
}
