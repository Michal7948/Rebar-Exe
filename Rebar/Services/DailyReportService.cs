
using Repositories;
using Repositories.Models;

namespace Services
{
    public class DailyReportService : IDailyReportService
    {
        IDailyReportRepository repo;
        public DailyReportService(IDailyReportRepository repo)
        {
            this.repo = repo;
        }
        public void Create(DailyReport dailyReport)
        {
            dailyReport.Date = DateOnly.FromDateTime(DateTime.Now).ToString();
            repo.Create(dailyReport);
        }

        public void Delete(string id)
        {
            repo.Delete(id);
        }

        public DailyReport GetById(string id)
        {
            return repo.GetById(id);
        }

        public List<DailyReport> GetList()
        {
            return repo.GetAll();
        }

        public void Update(string id, DailyReport dailyReport)
        {
            repo.Update(id, dailyReport);
        }
    }
}
