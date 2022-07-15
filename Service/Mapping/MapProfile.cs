using AutoMapper;
using Core.DTOs;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Mapping
{
    public class MapProfile : Profile 
    {
        public MapProfile()
        {
            CreateMap<Movie, MovieDTO>().ReverseMap();
            CreateMap<Movie, GetMovieDetailDTO>().ReverseMap();
            CreateMap<Movie, GetMovieListDTO>().ReverseMap();

            CreateMap<Genre, AddGenreDTO>().ReverseMap();
            CreateMap<Genre, ListGenreDTO>().ReverseMap();
        }
    }
}
