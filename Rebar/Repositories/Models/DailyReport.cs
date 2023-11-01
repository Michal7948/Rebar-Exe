
namespace Repositories.Models
{
    public class DailyReport
    {
        public string Id { get; } 
        public string Date { get; set; } //= DateOnly.FromDateTime(DateTime.Now);
        public int OrdersAmount { get; set; }
        public double TotalRevenue { get; set; }

        public DailyReport()
        {
            Id = Guid.NewGuid().ToString();
            Date = DateOnly.FromDateTime(DateTime.Now).ToString();
            //Date = new DateOnly();
            //Date = DateOnly.FromDateTime(DateTime.Now);
        }
    }

    
}
