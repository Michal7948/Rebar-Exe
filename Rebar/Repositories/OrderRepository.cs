
using MongoDB.Driver;
using Repositories.Models;

namespace Repositories
{
    public class OrderRepository : IOrderRepository
    {
        string collectionOrder = "orders";
        RebarContext context;
        public OrderRepository(RebarContext context)
        {
            this.context = context;
        }
        public void Create(Order objToCreate)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Order> GetAll()
        {
            var ordersCollection = context.ConnectToMongoDB<Order>(collectionOrder);
            var results = ordersCollection.Find(_ => true);
            return results.ToList();
        }

        public Order GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Order objToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
