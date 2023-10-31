
namespace Repositories.Models
{
    public interface IRebarDatabaseSettings
    {
        public string ShakeCollectionName { get; set; }
        public string OrderCollectionName { get; set; }
        public string DailyReportCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }

    }
}
