namespace MvcStartApp.Models.Db
{ 
    /// <summary>
    /// Модель запроса
    /// </summary>
    public class Request
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public string Url { get; set; }
    }
}
