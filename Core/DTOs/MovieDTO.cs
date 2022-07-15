using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DTOs
{
    public class MovieDTO
    {
        public string? name { get; set; }
        public bool adult { get; set; }
        public string? budget { get; set; }
        public string? homepage { get; set; }
        public string? original_language { get; set; }
        public string? original_title { get; set; }
        public string? poster_path { get; set; }
        public DateTime? release_date { get; set; }
        public string? runtime { get; set; }
        public string? status { get; set; }
        public string? tagline { get; set; }
        public string? title { get; set; }
        public bool video { get; set; }
    }
}
