using AutoMapper;
using tp5.Dtos;
using tp5.Models;

namespace tp5.Helpers

{
    public class MappingProfile :Profile
    {
        public MappingProfile() {
            CreateMap<Movie, MovieDetailsDto>();
            CreateMap<MovieDto, Movie>().ForMember(src => src.Poster, opt => opt.Ignore());
        }

    }
}
