using AutoMapper;
using WebAPI.Data.Entities;
using WebAPI.DTOs.Cats;

namespace WebAPI.Profiles
{
    public class CatProfile : Profile
    {
        public CatProfile()
        {
            CreateMap<Cat, CatDTO>();
            CreateMap<Cat, CatResponseDTO>();
            CreateMap<CatRequestDTO, Cat>();
        }
    }
}
