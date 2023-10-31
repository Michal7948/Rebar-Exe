
using MongoDB.Driver;
using Repositories.Models;

namespace Repositories
{
    public class DailyReportRepository : IDailyReportRepository
    {
        private readonly IMongoCollection<DailyReport> _dailyReport;
        public DailyReportRepository(IRebarDatabaseSettings settings, IMongoClient mongoClient)
        {
            var database = mongoClient.GetDatabase(settings.DatabaseName);
            _dailyReport = database.GetCollection<DailyReport>(settings.DailyReportCollectionName);
        }
        public void Create(DailyReport objToCreate)
        {
            _dailyReport.InsertOne(objToCreate);
        }

        public void Delete(string id)
        {
            _dailyReport.DeleteOne(dailyReport => dailyReport.Id == id);
        }

        public List<DailyReport> GetAll()
        {
            return _dailyReport.Find(dailyReport => true).ToList();
        }

        public DailyReport GetById(string id)
        {
            return _dailyReport.Find(dailyReport => dailyReport.Id == id).FirstOrDefault();
        }

        public void Update(string id, DailyReport objToUpdate)
        {
            _dailyReport.ReplaceOne(dailyReport => dailyReport.Id == id, objToUpdate);
        }
    }
}
