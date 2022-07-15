using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Movie
    {
        public int id { get; set; }
        public bool adult { get; set; }
        public string? budget { get; set; }
        public string? homepage { get; set; }
        public string? imdb_id { get; set; }
        public string? original_language { get; set; }
        public string? original_title { get; set; }
        public string? overview { get; set; }
        public string? popularity { get; set; }
        public string? poster_path { get; set; }
        public DateTime? release_date { get; set; }
        public string? revenue { get; set; }
        public string? runtime { get; set; }
        public string? status { get; set; }
        public string? tagline { get; set; }
        public string? title { get; set; }
        public bool video { get; set; }
        public string vote_average { get; set; }
        public string vote_count { get; set; }


        public int? collectionid { get; set; }

        public Collection? collection { get; set; }

        public List<Genre>? genres { get; set; }
        public List<ProductionCompanies>? productioncompanies { get; set; }
        public List<ProductionCountries>? productioncountries { get; set; }
        public List<SpokenLanguages>? spokenlanguages { get; set; }
    }
}
