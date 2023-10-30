
using MongoDB.Driver;
using Repositories.Models;

namespace Repositories
{
    public class ShakeRepository : IShakeRepository
    {
        string collectionShake = "shakes";

        RebarContext context;
        private readonly IMongoCollection<Shake> shakesCollection;

        public ShakeRepository(RebarContext context)
        {
            this.context = context;
            shakesCollection = context.ConnectToMongoDB<Shake>(collectionShake);
        }
        public void Create(Shake objToCreate)
        {
           shakesCollection.InsertOneAsync(objToCreate);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Shake> GetAll()
        {
            return shakesCollection.Find(shake => true).ToList();
            
            //var shakesCollection = context.ConnectToMongoDB<Shake>(collectionShake);
            //var results = shakesCollection.Find(_ => true);
            //return results.ToList();
        }

        public Shake GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Shake objToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
