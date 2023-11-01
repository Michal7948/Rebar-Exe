
namespace Repositories.Models
{
    public class Order
    {
        public string Id { get;} 
        public string ClientName { get; set; }
        public List<ShakeForOrder> ShakesWithPrice { get; set; }
        public double sumPriceAllShakesList { get; set; }
        public DateTime DateOrder { get; set; }
        public List<Sales> Sales { get; set; }

        public Order()
        {
            Id = Guid.NewGuid().ToString();
        }

    }
}
