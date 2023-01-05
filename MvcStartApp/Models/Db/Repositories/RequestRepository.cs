using Microsoft.EntityFrameworkCore;

namespace MvcStartApp.Models.Db.Repositories
{
    public class RequestRepository : IRequestRepository
    {
        private readonly BlogContext _context;

        public RequestRepository(BlogContext context)
        {
            _context = context;
        }

        public async Task Add(Request request)
        {
            var entry = _context.Entry(request);
            if (entry.State == EntityState.Detached)
                await _context.Requests.AddAsync(request);

            await _context.SaveChangesAsync();
        }

        public async Task<Request[]> GetAll()
        {
            return await _context.Requests.ToArrayAsync();
        }
    }
}
