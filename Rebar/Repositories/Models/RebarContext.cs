
using MongoDB.Driver;


namespace Repositories.Models
{
    public class RebarContext
    {
        public const string connectionString = "mongodb://127.0.0.1:27017";
        public const string databaseName = "reber_db";

        public IMongoCollection<T> ConecctToMongoDB<T>(in string collection)
        {
            var client = new MongoClient(connectionString);
            var db = client.GetDatabase(databaseName);
            return db.GetCollection<T>(collection);
        }



    }
}
