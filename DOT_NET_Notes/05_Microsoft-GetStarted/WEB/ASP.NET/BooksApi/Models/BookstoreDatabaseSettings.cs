namespace BooksApi.Models{
    /**
    *   BookstoreDatabaseSettings class.
    *   class is used to store the appsettings.json file's BookstoreDatabaseSettings property values.
    */
    public class BookstoreDatabaseSettings : IBookstoreDatabaseSettings {
        public string BooksCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }

    }
    /**
    *   IBookstoreDatabaseSettings interface.
    */
    public interface IBookstoreDatabaseSettings {
        string BooksCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}