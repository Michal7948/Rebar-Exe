using MongoDB.Bson.Serialization.Attributes;

namespace Repositories.Models
{
    public class Shake
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }//change to GUID
        public string Name { get; set; }//must be of menu.
        public string Description { get; set; }
        public double PriceSizeL { get; set; }
        public double PriceSizeM { get; set; }
        public double PriceSizeS { get; set; }



    }
}
