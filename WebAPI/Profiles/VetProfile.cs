using AutoMapper;
using WebAPI.Data.Entities;
using WebAPI.DTOs.Vets;

namespace WebAPI.Profiles
{
    public class VetProfile : Profile
    {
        public VetProfile()
        {
            CreateMap<Vet, VetDTO>();
            CreateMap<Vet, VetResponseDTO>();
            CreateMap<VetRequestDTO, Vet>();
        }

    }
}
