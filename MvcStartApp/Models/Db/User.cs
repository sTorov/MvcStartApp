﻿namespace MvcStartApp.Models.Db
{
    /// <summary>
    /// Модель пользователя
    /// </summary>
    public class User
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime JoinDate { get; set; }
    }
}
