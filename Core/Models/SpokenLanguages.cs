using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class SpokenLanguages
    {
        public string iso_639_1 { get; set; }
        public string? name { get; set; }

        public List<Movie>? movies { get; set; }
    }
}
