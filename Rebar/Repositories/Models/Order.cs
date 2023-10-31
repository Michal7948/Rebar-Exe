
namespace Repositories.Models
{
    public class Order
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string ClientName { get; set; }
        public int MyProperty { get; set; }
        public List<Shake> ShakesWithPrice { get; set; }//I will add price into the list.
        public double sumPriceAllShakesList { get; set; }
        public DateTime DateOrder { get; set; }
        // Discounts and promotions (if any)

    }
}
