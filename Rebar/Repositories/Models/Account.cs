
namespace Repositories.Models
{
    public class Account
    {
        public List<Order> Orders { get; set; }
        public double SumAllOrdersInAccount { get; set; }
    }
}
