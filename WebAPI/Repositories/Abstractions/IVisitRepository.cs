using WebAPI.Data.Entities;

namespace WebAPI.Repositories.Abstractions
{
    public interface IVisitRepository
    {
        Task CreateAsync(Visit visit);
    }
}
