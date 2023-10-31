
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
            repo.Create(dailyReport);
        }

        public void Delete(Guid id)
        {
            repo.Delete(id);
        }

        public DailyReport GetById(Guid id)
        {
            return repo.GetById(id);
        }

        public List<DailyReport> GetList()
        {
            return repo.GetAll();
        }

        public void Update(Guid id, DailyReport dailyReport)
        {
            repo.Update(id, dailyReport);
        }
    }
}
