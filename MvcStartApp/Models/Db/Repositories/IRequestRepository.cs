namespace MvcStartApp.Models.Db.Repositories
{
    /// <summary>
    /// Интерфейс репозитория запросов
    /// </summary>
    public interface IRequestRepository
    {
        /// <summary>
        /// Добавление записи о запросе в БД
        /// </summary>
        Task Add(Request request);
        /// <summary>
        /// Получение списка всех запросов, имеющихся в БД
        /// </summary>
        Task<Request[]> GetAll();
    }
}
