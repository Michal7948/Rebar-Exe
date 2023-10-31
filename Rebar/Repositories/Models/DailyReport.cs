
namespace Repositories.Models
{
    public class DailyReport
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateOnly Date { get; set; }
        public int OrdersAmount { get; set; }
        public double TotalRevenue { get; set; }
    }
}
