
using MongoDB.Driver;
using Repositories.Models;

namespace Repositories
{
    public class ShakeRepository : IShakeRepository
    {
        private readonly IMongoCollection<Shake> _shake;
        public ShakeRepository(IRebarDatabaseSettings settings,IMongoClient mongoClient)
        {
            var database = mongoClient.GetDatabase(settings.DatabaseName);
            _shake= database.GetCollection<Shake>(settings.ShakeCollectionName);
        }
        public void Create(Shake objToCreate)
        {
            _shake.InsertOne(objToCreate);
        }

        public void Delete(string id)
        {
            _shake.DeleteOne(shake => shake.Id == id);
        }

        public List<Shake> GetAll()
        {
           return _shake.Find(shake => true).ToList();
        }

        public Shake GetById(string id)
        {
            return _shake.Find(shake => shake.Id == id).FirstOrDefault();
        }

        public void Update(string id,Shake objToUpdate)
        {
            _shake.ReplaceOne(shake => shake.Id == id,objToUpdate);
        }
    }
}
