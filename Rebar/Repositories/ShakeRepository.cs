
using MongoDB.Driver;
using Repositories.Models;

namespace Repositories
{
    public class ShakeRepository : IShakeRepository
    {
        string collectionShake = "shakes";
        RebarContext context;
        public ShakeRepository(RebarContext context)
        {
            this.context = context;
        }
        public void Create(Shake objToCreate)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Shake> GetAll()
        {
            var shakesCollection = context.ConecctToMongoDB<Shake>(collectionShake);
            var results = shakesCollection.Find(_ => true);
            return results.ToList();
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
