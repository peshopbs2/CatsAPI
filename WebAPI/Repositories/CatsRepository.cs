using WebAPI.Data;
using WebAPI.Data.Entities;
using WebAPI.Repositories.Abstractions;

namespace WebAPI.Repositories
{
    public class CatsRepository : CrudRepository<Cat>, ICatsRepository
    {
        private readonly AppDbContext _context;

        public CatsRepository(AppDbContext context)
            : base(context)
        {
        }
    }
}
