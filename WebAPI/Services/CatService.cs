using AutoMapper;
using WebAPI.Data.Entities;
using WebAPI.DTOs.Cats;
using WebAPI.DTOs.Visits;
using WebAPI.Repositories.Abstractions;
using WebAPI.Services.Abstraction;

namespace WebAPI.Services
{
    public class CatService : ICatService
    {
        private readonly ICatsRepository _catsRepository;
        private readonly IVisitRepository _visitRepository;
        private readonly IMapper _mapper;
        public CatService(ICatsRepository catsRepository, IVisitRepository visitRepository, IMapper mapper)
        {
            _catsRepository = catsRepository;
            _visitRepository = visitRepository;
            _mapper = mapper;
        }

        public async Task AddCatVisitAsync(VisitRequestDTO visitRequestDto)
        {
            var visit = _mapper.Map<Visit>(visitRequestDto);
            await _visitRepository.CreateAsync(visit);
        }

        public async Task CreateAsync(CatRequestDTO catDto)
        {
            var cat = _mapper.Map<Cat>(catDto);
            await _catsRepository.CreateAsync(cat);
        }

        public async Task DeleteAsync(int catId)
        {
            await _catsRepository.DeleteByIdAsync(catId);
        }

        public async Task<ICollection<CatResponseDTO>> GetAllAsync()
        {
            var cats = await _catsRepository.GetAllAsync();
            return _mapper.Map<ICollection<CatResponseDTO>>(cats);
        }

        public async Task<CatResponseDTO> GetByIdAsync(int id)
        {
            var cat = await _catsRepository.GetByIdAsync(id);
            return _mapper.Map<CatResponseDTO>(cat);
        }

        public ICollection<CatResponseDTO> GetByName(string name)
        {
            var cats = _catsRepository.GetByFilter(cat => cat.Name == name);
            return _mapper.Map<ICollection<CatResponseDTO>>(cats);
        }

        public async Task UpdateAsync(CatRequestDTO catDto)
        {
            var cat = _mapper.Map<Cat>(catDto);
            await _catsRepository.UpdateAsync(cat);
        }
    }
}
