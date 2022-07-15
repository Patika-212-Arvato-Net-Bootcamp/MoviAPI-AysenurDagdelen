using Core.Models;
using Repository.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class CollectionRepository : GenericRepository<Collection>, ICollectionRepository
    {
        private readonly AppDbContext _appDbContext;
        public CollectionRepository(AppDbContext appDbContext) : base(appDbContext)
        {
            _appDbContext = appDbContext;   
        }
    }
}
