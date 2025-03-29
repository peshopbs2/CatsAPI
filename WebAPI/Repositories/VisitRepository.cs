using WebAPI.Data;
using WebAPI.Data.Entities;
using WebAPI.Repositories.Abstractions;

namespace WebAPI.Repositories
{
    public class VisitRepository : IVisitRepository
    {
        private AppDbContext _context;
        public VisitRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(Visit visit)
        {
            _context.Visit.Add(visit);
            await _context.SaveChangesAsync();
        }
    }
}
