using WebAPI.DTOs.Cats;
using WebAPI.DTOs.Vets;

namespace WebAPI.DTOs.Visits
{
    public class VisitResponseDTO : VisitDTO
    {
        public VetResponseDTO Vet { get; set; }
        public CatResponseDTO Cat { get; set; }
    }
}
