
using Repositories;
using Repositories.Models;

namespace Services
{
    public class OrderService : IOrderService
    {
        IOrderRepository repo;
        public OrderService(IOrderRepository repo)
        {
            this.repo = repo;
        }
        public void Create(Order order)
        {
            repo.Create(order);
        }

        public void Delete(string id)
        {
            repo.Delete(id);
        }

        public Order GetById(string id)
        {
            return repo.GetById(id);
        }

        public List<Order> GetList()
        {
            return repo.GetAll();
        }

        public void Update(string id, Order order)
        {
            repo.Update(id, order);
        }
    }
}
