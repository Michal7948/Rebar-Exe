
using MongoDB.Driver;
using Repositories.Models;

namespace Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly IMongoCollection<Order> _order;

        public OrderRepository(IRebarDatabaseSettings settings, IMongoClient mongoClient)
        {
            var database = mongoClient.GetDatabase(settings.DatabaseName);
            _order = database.GetCollection<Order>(settings.OrderCollectionName);
        }

        public List<Order> GetAll()
        {
            return _order.Find(shake => true).ToList();
        }

        public Order GetById(Guid id)
        {
            return _order.Find(shake => shake.Id == id).FirstOrDefault();
        }

        public void Create(Order objToCreate)
        {
            _order.InsertOne(objToCreate);
        }

        public void Update(Guid id, Order objToUpdate)
        {
            _order.ReplaceOne(shake => shake.Id == id, objToUpdate);
        }

        public void Delete(Guid id)
        {
            _order.DeleteOne(shake => shake.Id == id);
        }
    }
}
