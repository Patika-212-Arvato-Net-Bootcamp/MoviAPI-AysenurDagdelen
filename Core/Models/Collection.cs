using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Collection
    {
        public int id { get; set; }
        public string? name { get; set; }
        public string? poster_path { get; set; }
        public string? backdrop_path { get; set; }

        public List<Movie>? movies { get; set; }
    }
}
