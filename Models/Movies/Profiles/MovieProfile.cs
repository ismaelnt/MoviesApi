using AutoMapper;
using MoviesApi.Models.Movies.Dtos;
using MoviesApi.Models.Movies.Entities;

namespace MoviesApi.Models.Movies.Profiles
{
    public class MovieProfile : Profile
    {
        public MovieProfile()
        {
            CreateMap<CreateMovieDto, Movie>();
            CreateMap<UpdateMovieDto, Movie>();
            CreateMap<Movie, ReadMovieDto>();
        }
    }
}
