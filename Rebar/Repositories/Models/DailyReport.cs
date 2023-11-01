
namespace Repositories.Models
{
    public class DailyReport
    {
        public string Id { get; } 
        public string Date { get; set; } 
        public int OrdersAmount { get; set; }
        public double TotalRevenue { get; set; }

        public DailyReport()
        {
            Id = Guid.NewGuid().ToString(); 
        }
    }

    
}
