namespace MvcStartApp.Models.Db.Repositories
{
    public interface IRequestRepository
    {
        Task Add(Request request);
        Task<Request[]> GetAll();
    }
}
