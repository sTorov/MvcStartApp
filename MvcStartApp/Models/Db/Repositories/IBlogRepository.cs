namespace MvcStartApp.Models.Db.Repositories
{
    /// <summary>
    /// Интерфейс репозитория блога
    /// </summary>
    public interface IBlogRepository
    {
        /// <summary>
        /// Добавление нового пользователя в БД
        /// </summary>
        Task AddUser(User user);
        /// <summary>
        /// Получение списка всех пользователей, имеющихся в БД
        /// </summary>
        Task<User[]> GetUsers();
    }
}
