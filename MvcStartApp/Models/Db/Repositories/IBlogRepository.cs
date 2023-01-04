namespace MvcStartApp.Models.Db.Repositories
{
    public interface IBlogRepository
    {
        Task AddUser(User user);
    }
}
