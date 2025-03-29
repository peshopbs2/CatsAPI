using WebAPI.DTOs.Cats;
using WebAPI.DTOs.Visits;

namespace WebAPI.Services.Abstraction
{
    public interface ICatService
    {
        Task<CatResponseDTO> GetByIdAsync(int id);
        Task<ICollection<CatResponseDTO>> GetAllAsync();
        Task CreateAsync(CatRequestDTO catDto);
        Task UpdateAsync(CatRequestDTO catDto);
        Task DeleteAsync(int catId);
        ICollection<CatResponseDTO> GetByName(string name);
        Task AddCatVisitAsync(VisitRequestDTO visitRequestDto);
    }
}
