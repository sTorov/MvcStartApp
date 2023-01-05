# MVCStartApp

### **Задание**
1. Сделать логирование всех запросов к нашему приложению в базу данных. Логирование должно происходить через `LoggingMiddleware`. Для работы с базой подключите свой отдельный репозиторий.  

2. Сделать отдельное представление, на котором можно будет посмотреть историю запросов к проекту. Представление должно быть доступно по адресу https://localhost:5001/logs.

___

### **Описание решения**

В данном решении били проделаны задания из модуля 32 *"ASP.Net Core + MVC"*, о также выполнена практическая часть:
 - Была добавлена модель данных `Request`.
 - Был добавлен интерфейс `IRequestRepository`. Реализован данный интерфейс классом `RequestRepository`.
 - Запись информации о запросах в базу данных реализована в классе `LoggingMiddleware`.
 - Был создан контроллер `LogsController`.
 - Было создано отдельное представление `index.cshtml` для контроллера `LogsController`, в котором можно просмотреть всю историю сделаных запросов в виде таблицы.