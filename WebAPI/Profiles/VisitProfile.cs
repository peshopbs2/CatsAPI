using AutoMapper;
using WebAPI.Data.Entities;
using WebAPI.DTOs.Visits;

namespace WebAPI.Profiles
{
    public class VisitProfile : Profile
    {
        public VisitProfile()
        {
            CreateMap<Visit, VisitDTO>();
            CreateMap<Visit, VisitResponseDTO>();
            CreateMap<VisitRequestDTO, Visit>();
        }
    }
}
